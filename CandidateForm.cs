using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JobFit
{
    public partial class CandidateForm : Form
    {
        public CandidateForm()
        {
            InitializeComponent();
        }

        private void CandidateForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddCandidateButton_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=office\\SQLEXPRESS;Initial Catalog=JobFit;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Candidate (FirstName, LastName, Location, TargetSalaryRange, Position, Specialty, YearsOfExperience, RemoteOrOnsite) " +
                                   "VALUES (@FirstName, @LastName, @Location, @TargetSalaryRange, @Position, @Specialty, @YearsOfExperience, @RemoteOrOnsite)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Location", LocationTextBox.Text);
                        cmd.Parameters.AddWithValue("@TargetSalaryRange", TargetSalaryRangeTextBox.Text);
                        cmd.Parameters.AddWithValue("@Position", PositionTextBox.Text);
                        cmd.Parameters.AddWithValue("@Specialty", SpecialtyTextBox.Text);
                        cmd.Parameters.AddWithValue("@YearsOfExperience", YearsOfExperienceTextBox.Text);
                        cmd.Parameters.AddWithValue("@RemoteOrOnsite", RemoteorOnsite.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Candidate added successfully.");
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
