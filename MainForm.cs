using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JobFit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ваши действия здесь
        }
        private void AddCandidate_Click(object sender, EventArgs e)
        {
            CandidateForm candidateForm = new CandidateForm();
            candidateForm.FormClosed += CandidateForm_FormClosed;
            candidateForm.ShowDialog();
        }

        private void CandidateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseFunctions.UpdateMatchTable();
            RefreshDataGridView();
        }

        private void AddJobOrder_Click(object sender, EventArgs e)
        {
            JobOrderForm jobOrderForm = new JobOrderForm();
            jobOrderForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DatabaseFunctions.UpdateMatchTable();
            this.matchTableAdapter1.Fill(this.jobFitDataSet.match);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            DatabaseFunctions.UpdateMatchTable();
            double matchPercentage = trackBar1.Value * 0.05;

            label1.Text = matchPercentage.ToString();

            string connectionString = "Data Source=OFFICE\\SQLEXPRESS;Initial Catalog=JobFit;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [match] WHERE [match_percentage] >= @value";

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@value", matchPercentage);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void editCandidate_Click(object sender, EventArgs e)
        {
            EditCandidate EditCandidate = new EditCandidate();
            EditCandidate.ShowDialog();
        }
    }
}