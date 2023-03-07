using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JobFit
{
    public partial class JobOrderForm : Form
    {
        public JobOrderForm()
        {
            InitializeComponent();
        }

        private void JobOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void AddJobOrderButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=OFFICE\\SQLEXPRESS;Initial Catalog=JobFit;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO joborder (CompanyName, JobOrderNumber, Position, Location, RemoteOrOnsite, TargetSalaryRange, Specialty, YearsOfExperience, VacancyDescription) " +
                                   "VALUES (@CompanyName, @JobOrderNumber, @Position, @Location, @RemoteOrOnsite, @TargetSalaryRange, @Specialty, @YearsOfExperience, @VacancyDescription)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", CompanyNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@JobOrderNumber", JobOrderNumbertextBox.Text);
                        cmd.Parameters.AddWithValue("@Position", PositiontextBox.Text);
                        cmd.Parameters.AddWithValue("@Location", LocationtextBox.Text);
                        cmd.Parameters.AddWithValue("@RemoteOrOnsite", RemoteOrOnsitecomboBox.Text);
                        cmd.Parameters.AddWithValue("@TargetSalaryRange", TargetSalaryRangetextBox.Text);
                        cmd.Parameters.AddWithValue("@Specialty", SpecialtytextBox.Text);
                        cmd.Parameters.AddWithValue("@YearsOfExperience", YearsOfExperiencetextBox.Text);
                        cmd.Parameters.AddWithValue("@VacancyDescription", VacancyDescriptionRichTextBox.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Job Order added successfully.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    DatabaseFunctions.UpdateMatchTable();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
