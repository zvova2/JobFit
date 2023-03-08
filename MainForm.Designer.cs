
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matchBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobFitDataSet = new JobFit.JobFitDataSet();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nEWJobFitDataSet = new JobFit.NEWJobFitDataSet();
            this.matchTableAdapter = new JobFit.NEWJobFitDataSetTableAdapters.matchTableAdapter();
            this.editCandidate = new System.Windows.Forms.Button();
            this.matchTableAdapter1 = new JobFit.JobFitDataSetTableAdapters.matchTableAdapter();
            this.matchpercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joborderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWJobFitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCandidate
            // 
            this.AddCandidate.Location = new System.Drawing.Point(12, 147);
            this.AddCandidate.Name = "AddCandidate";
            this.AddCandidate.Size = new System.Drawing.Size(192, 30);
            this.AddCandidate.TabIndex = 0;
            this.AddCandidate.Text = "Add Candidate";
            this.AddCandidate.UseVisualStyleBackColor = true;
            this.AddCandidate.Click += new System.EventHandler(this.AddCandidate_Click);
            // 
            // AddJobOrder
            // 
            this.AddJobOrder.Location = new System.Drawing.Point(777, 147);
            this.AddJobOrder.Name = "AddJobOrder";
            this.AddJobOrder.Size = new System.Drawing.Size(189, 33);
            this.AddJobOrder.TabIndex = 1;
            this.AddJobOrder.Text = "Add Job Order";
            this.AddJobOrder.UseVisualStyleBackColor = true;
            this.AddJobOrder.Click += new System.EventHandler(this.AddJobOrder_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(297, 71);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchpercentageDataGridViewTextBoxColumn,
            this.candidatenameDataGridViewTextBoxColumn,
            this.joborderidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matchBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(236, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 686);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // matchBindingSource1
            // 
            this.matchBindingSource1.DataMember = "match";
            this.matchBindingSource1.DataSource = this.jobFitDataSet;
            // 
            // jobFitDataSet
            // 
            this.jobFitDataSet.DataSetName = "JobFitDataSet";
            this.jobFitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataMember = "match";
            this.matchBindingSource.DataSource = this.nEWJobFitDataSet;
            // 
            // nEWJobFitDataSet
            // 
            this.nEWJobFitDataSet.DataSetName = "NEWJobFitDataSet";
            this.nEWJobFitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matchTableAdapter
            // 
            this.matchTableAdapter.ClearBeforeFill = true;
            // 
            // editCandidate
            // 
            this.editCandidate.Location = new System.Drawing.Point(12, 184);
            this.editCandidate.Name = "editCandidate";
            this.editCandidate.Size = new System.Drawing.Size(192, 23);
            this.editCandidate.TabIndex = 6;
            this.editCandidate.Text = "Edit Candidate";
            this.editCandidate.UseVisualStyleBackColor = true;
            this.editCandidate.Click += new System.EventHandler(this.editCandidate_Click);
            // 
            // matchTableAdapter1
            // 
            this.matchTableAdapter1.ClearBeforeFill = true;
            // 
            // matchpercentageDataGridViewTextBoxColumn
            // 
            this.matchpercentageDataGridViewTextBoxColumn.DataPropertyName = "match_percentage";
            this.matchpercentageDataGridViewTextBoxColumn.HeaderText = "match (%)";
            this.matchpercentageDataGridViewTextBoxColumn.Name = "matchpercentageDataGridViewTextBoxColumn";
            // 
            // candidatenameDataGridViewTextBoxColumn
            // 
            this.candidatenameDataGridViewTextBoxColumn.DataPropertyName = "candidate_name";
            this.candidatenameDataGridViewTextBoxColumn.HeaderText = "Candidate Name";
            this.candidatenameDataGridViewTextBoxColumn.Name = "candidatenameDataGridViewTextBoxColumn";
            // 
            // joborderidDataGridViewTextBoxColumn
            // 
            this.joborderidDataGridViewTextBoxColumn.DataPropertyName = "joborder_id";
            this.joborderidDataGridViewTextBoxColumn.HeaderText = "Job Order Number";
            this.joborderidDataGridViewTextBoxColumn.Name = "joborderidDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1036, 888);
            this.Controls.Add(this.editCandidate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.AddJobOrder);
            this.Controls.Add(this.AddCandidate);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWJobFitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCandidate;
        private System.Windows.Forms.Button AddJobOrder;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NEWJobFitDataSet nEWJobFitDataSet;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private NEWJobFitDataSetTableAdapters.matchTableAdapter matchTableAdapter;
        private System.Windows.Forms.Button editCandidate;
        private JobFitDataSet jobFitDataSet;
        private System.Windows.Forms.BindingSource matchBindingSource1;
        private JobFitDataSetTableAdapters.matchTableAdapter matchTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchpercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidatenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joborderidDataGridViewTextBoxColumn;
    }
}