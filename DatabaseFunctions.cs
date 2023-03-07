using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JobFit
{
    static class DatabaseFunctions
    {
        public static void UpdateMatchTable()
        {
            string connectionString = "Data Source=OFFICE\\SQLEXPRESS;Initial Catalog=JobFit;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Запрос для обновления таблицы match
                    string insertQuery = "INSERT INTO [match] ([candidate_id], [candidate_Name], [joborder_id], [joborder_Number], [match_percentage]) " +
                                            "SELECT c.[id], c.[FirstName] + ' ' + c.[LastName], e.[id], e.[JobOrderNumber], ((CASE WHEN c.[Specialty] = e.[Specialty] THEN 1 ELSE 0 END * 100) + " +
                                            "(CASE WHEN c.[Position] = e.[Position] THEN 1 ELSE 0 END * 50) + (CASE WHEN c.[Location] = e.[Location] THEN 1 ELSE 0 END * 25) + " +
                                            "(CASE WHEN c.[RemoteOrOnsite] = e.[RemoteOrOnsite] THEN 1 ELSE 0 END * 12.5) + " +
                                            "(CASE WHEN c.[TargetSalaryRange] = e.[TargetSalaryRange] THEN 1 ELSE 0 END * 6.25) + " +
                                            "(CASE WHEN c.[YearsOfExperience] = e.[YearsOfExperience] THEN 1 ELSE 0 END * 6.25)) / 200 AS match_percentage " +
                                            "FROM [candidate] AS c, [joborder] AS e " +
                                            "WHERE NOT EXISTS (" +
                                            "SELECT * FROM [match] WHERE [candidate_id] = c.[id] AND [joborder_id] = e.[id]" +
                                            ")";
                    string updateQuery = "UPDATE [match] " +
                                   "SET [candidate_name] = c.[FirstName] + ' ' + c.[LastName], " +
                                   "[joborder_number] = e.[JobOrderNumber], " +
                                   "[match_percentage] = ((CASE WHEN c.[Specialty] = e.[Specialty] THEN 1 ELSE 0 END * 100) + " +
                                   "(CASE WHEN c.[Position] = e.[Position] THEN 1 ELSE 0 END * 50) + (CASE WHEN c.[Location] = e.[Location] THEN 1 ELSE 0 END * 25) + " +
                                   "(CASE WHEN c.[RemoteOrOnsite] = e.[RemoteOrOnsite] THEN 1 ELSE 0 END * 12.5) + " +
                                   "(CASE WHEN c.[TargetSalaryRange] = e.[TargetSalaryRange] THEN 1 ELSE 0 END * 6.25) + " +
                                   "(CASE WHEN c.[YearsOfExperience] = e.[YearsOfExperience] THEN 1 ELSE 0 END * 6.25)) / 200 " +
                                   "FROM [candidate] AS c, [joborder] AS e " +
                                   "WHERE [match].[candidate_id] = c.[id] AND [match].[joborder_id] = e.[id]";

                    SqlCommand command = new SqlCommand(insertQuery + ";" + updateQuery, connection);
                    command.ExecuteNonQuery();

                   

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}



