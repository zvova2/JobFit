
namespace JobFit
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddCandidate = new System.Windows.Forms.Button();
            this.AddJobOrder = new System.Windows.Forms.Button();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobordernumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobFitDataSet = new JobFit.JobFitDataSet();
            this.matchTableAdapter = new JobFit.JobFitDataSetTableAdapters.matchTableAdapter();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCandidate
            // 
            this.AddCandidate.Location = new System.Drawing.Point(28, 23);
            this.AddCandidate.Name = "AddCandidate";
            this.AddCandidate.Size = new System.Drawing.Size(192, 30);
            this.AddCandidate.TabIndex = 0;
            this.AddCandidate.Text = "Add Candidate";
            this.AddCandidate.UseVisualStyleBackColor = true;
            this.AddCandidate.Click += new System.EventHandler(this.AddCandidate_Click);
            // 
            // AddJobOrder
            // 
            this.AddJobOrder.Location = new System.Drawing.Point(30, 88);
            this.AddJobOrder.Name = "AddJobOrder";
            this.AddJobOrder.Size = new System.Drawing.Size(189, 33);
            this.AddJobOrder.TabIndex = 1;
            this.AddJobOrder.Text = "Add Job Order";
            this.AddJobOrder.UseVisualStyleBackColor = true;
            this.AddJobOrder.Click += new System.EventHandler(this.AddJobOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.candidatenameDataGridViewTextBoxColumn,
            this.jobordernumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matchBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(437, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(884, 646);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "match_percentage";
            this.dataGridViewTextBoxColumn1.HeaderText = "match_percentage";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // candidatenameDataGridViewTextBoxColumn
            // 
            this.candidatenameDataGridViewTextBoxColumn.DataPropertyName = "candidate_name";
            this.candidatenameDataGridViewTextBoxColumn.HeaderText = "candidate_name";
            this.candidatenameDataGridViewTextBoxColumn.Name = "candidatenameDataGridViewTextBoxColumn";
            // 
            // jobordernumberDataGridViewTextBoxColumn
            // 
            this.jobordernumberDataGridViewTextBoxColumn.DataPropertyName = "joborder_number";
            this.jobordernumberDataGridViewTextBoxColumn.HeaderText = "joborder_number";
            this.jobordernumberDataGridViewTextBoxColumn.Name = "jobordernumberDataGridViewTextBoxColumn";
            // 
            // matchBindingSource1
            // 
            this.matchBindingSource1.DataMember = "match";
            this.matchBindingSource1.DataSource = this.jobFitDataSet;
            // 
            // jobFitDataSet
            // 
            this.jobFitDataSet.DataSetName = "JobFitDataSet";
     
            // 
            // matchTableAdapter
            // 
            this.matchTableAdapter.ClearBeforeFill = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(30, 147);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(383, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 846);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1834, 888);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddJobOrder);
            this.Controls.Add(this.AddCandidate);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCandidate;
        private System.Windows.Forms.Button AddJobOrder;

        private System.Windows.Forms.BindingSource dataSet1BindingSource;

        private System.Windows.Forms.BindingSource matchBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn candidateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joborderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchpercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JobFitDataSet jobFitDataSet;
        private System.Windows.Forms.BindingSource matchBindingSource1;
        private JobFitDataSetTableAdapters.matchTableAdapter matchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobordernumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}