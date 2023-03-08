
namespace JobFit
{
    partial class EditCandidate
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.candidatesDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetSalaryRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearsOfExperienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remoteOrOnsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobFitDataSet = new JobFit.JobFitDataSet();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.nEWJobFitDataSet = new JobFit.NEWJobFitDataSet();
            this.nEWJobFitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter = new JobFit.JobFitDataSetTableAdapters.candidateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWJobFitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWJobFitDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(86, 13);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(239, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(374, 13);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // candidatesDataGridView
            // 
            this.candidatesDataGridView.AllowUserToAddRows = false;
            this.candidatesDataGridView.AllowUserToOrderColumns = true;
            this.candidatesDataGridView.AutoGenerateColumns = false;
            this.candidatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.targetSalaryRangeDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.yearsOfExperienceDataGridViewTextBoxColumn,
            this.remoteOrOnsiteDataGridViewTextBoxColumn});
            this.candidatesDataGridView.DataSource = this.candidateBindingSource;
            this.candidatesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.candidatesDataGridView.Location = new System.Drawing.Point(29, 93);
            this.candidatesDataGridView.Name = "candidatesDataGridView";
            this.candidatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.candidatesDataGridView.Size = new System.Drawing.Size(847, 603);
            this.candidatesDataGridView.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // targetSalaryRangeDataGridViewTextBoxColumn
            // 
            this.targetSalaryRangeDataGridViewTextBoxColumn.DataPropertyName = "TargetSalaryRange";
            this.targetSalaryRangeDataGridViewTextBoxColumn.HeaderText = "TargetSalaryRange";
            this.targetSalaryRangeDataGridViewTextBoxColumn.Name = "targetSalaryRangeDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            // 
            // yearsOfExperienceDataGridViewTextBoxColumn
            // 
            this.yearsOfExperienceDataGridViewTextBoxColumn.DataPropertyName = "YearsOfExperience";
            this.yearsOfExperienceDataGridViewTextBoxColumn.HeaderText = "YearsOfExperience";
            this.yearsOfExperienceDataGridViewTextBoxColumn.Name = "yearsOfExperienceDataGridViewTextBoxColumn";
            // 
            // remoteOrOnsiteDataGridViewTextBoxColumn
            // 
            this.remoteOrOnsiteDataGridViewTextBoxColumn.DataPropertyName = "RemoteOrOnsite";
            this.remoteOrOnsiteDataGridViewTextBoxColumn.HeaderText = "RemoteOrOnsite";
            this.remoteOrOnsiteDataGridViewTextBoxColumn.Name = "remoteOrOnsiteDataGridViewTextBoxColumn";
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "candidate";
            this.candidateBindingSource.DataSource = this.jobFitDataSet;
            // 
            // jobFitDataSet
            // 
            this.jobFitDataSet.DataSetName = "JobFitDataSet";
            this.jobFitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(488, 13);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(591, 13);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // nEWJobFitDataSet
            // 
            this.nEWJobFitDataSet.DataSetName = "NEWJobFitDataSet";
            this.nEWJobFitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nEWJobFitDataSetBindingSource
            // 
            this.nEWJobFitDataSetBindingSource.DataSource = this.nEWJobFitDataSet;
            this.nEWJobFitDataSetBindingSource.Position = 0;
            // 
            // candidateTableAdapter
            // 
            this.candidateTableAdapter.ClearBeforeFill = true;
            // 
            // EditCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 966);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.candidatesDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "EditCandidate";
            this.Text = "EditCandidate";
            this.Load += new System.EventHandler(this.EditCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobFitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWJobFitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWJobFitDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView candidatesDataGridView;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.BindingSource nEWJobFitDataSetBindingSource;
        private NEWJobFitDataSet nEWJobFitDataSet;
        private JobFitDataSet jobFitDataSet;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private JobFitDataSetTableAdapters.candidateTableAdapter candidateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetSalaryRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearsOfExperienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remoteOrOnsiteDataGridViewTextBoxColumn;
    }
}