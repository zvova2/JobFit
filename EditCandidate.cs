using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JobFit
{
    public partial class EditCandidate : Form
    {
        string connectionString = "Data Source=OFFICE\\SQLEXPRESS;Initial Catalog=JobFit;Integrated Security=True";
        public EditCandidate()
        {
            InitializeComponent();
            this.candidatesDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.candidatesDataGridView_CellValueChanged);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Получаем строку поиска
            string searchString = searchTextBox.Text;
            

            // Формируем запрос к базе данных
            string query = "SELECT id, firstName, lastName, Specialty, Position, Location, RemoteOrOnsite, TargetSalaryRange, YearsOfExperience " +
                           "FROM candidate " +
                           "WHERE firstName LIKE '%" + searchString + "%' OR " +
                                 "lastName LIKE '%" + searchString + "%' OR " +
                                 "Specialty LIKE '%" + searchString + "%' OR " +
                                 "Position LIKE '%" + searchString + "%' OR " +
                                 "Location LIKE '%" + searchString + "%' OR " +
                                 "RemoteOrOnsite LIKE '%" + searchString + "%' OR " +
                                 "TargetSalaryRange LIKE '%" + searchString + "%' OR " +
                                 "YearsOfExperience LIKE '%" + searchString + "%'";

            // Выполняем запрос и загружаем результаты в DataGridView
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                candidatesDataGridView.DataSource = dataTable;
            }
        }

        private void EditCandidate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFitDataSet.candidate' table. You can move, or remove it, as needed.
            //this.candidateTableAdapter.Fill(this.jobFitDataSet.candidate);
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Получаем id выбранной записи
            int selectedId = (int)candidatesDataGridView.SelectedRows[0].Cells[0].Value;

            // Формируем запрос DELETE к базе данных
            string query = "DELETE FROM candidate " +
                           "WHERE id = " + selectedId;

            // Выполняем запрос
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }

            // Обновляем DataGridView
            SearchButton_Click(null, null);
        }
        private void candidatesDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    // получаем ID измененного кандидата
                    int candidateId = (int)candidatesDataGridView.Rows[e.RowIndex].Cells[0].Value;

                    // получаем новое значение измененной ячейки
                    string newValue = candidatesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    // обновляем соответствующую запись в базе данных
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlQuery = "UPDATE Candidate SET " + candidatesDataGridView.Columns[e.ColumnIndex].DataPropertyName + " = @newValue WHERE Id = @candidateId";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@newValue", newValue);
                        command.Parameters.AddWithValue("@candidateId", candidateId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении записи в базе данных: " + ex.Message);
                }
            }
        }







    }
}
