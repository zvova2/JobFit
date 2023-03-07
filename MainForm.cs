using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;

namespace JobFit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public enum DataGridViewColumnSortMode
        {
            Automatic,
            Programmatic,
            NotSortable
        }

        private void AddCandidate_Click(object sender, EventArgs e)
        {
            CandidateForm candidateForm = new CandidateForm();
            candidateForm.ShowDialog();
        }

        private void AddJobOrder_Click(object sender, EventArgs e)
        {
            JobOrderForm jobOrderForm = new JobOrderForm();
            jobOrderForm.ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // загрузить данные в таблицу, используя текущее значение ползунка
            trackBar1_Scroll(sender, e);
            DatabaseFunctions.UpdateMatchTable();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            double matchPercentage = value * 0.05;

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


    }
}
