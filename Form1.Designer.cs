namespace BaobaRidge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAnimals = new DataGridView();
            lblAnimalId = new Label();
            txtAnimalId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblSpecies = new Label();
            txtSpecies = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            txtScore = new TextBox();
            lblScore = new Label();
            btnAdd = new Button();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnViewSummary = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AllowUserToDeleteRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(30, 320);
            dgvAnimals.Margin = new Padding(3, 2, 3, 2);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(880, 206);
            dgvAnimals.TabIndex = 0;
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Location = new Point(30, 40);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(62, 15);
            lblAnimalId.TabIndex = 1;
            lblAnimalId.Text = "Animal ID:";
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(30, 65);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(190, 23);
            txtAnimalId.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(260, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(260, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 23);
            txtName.TabIndex = 4;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(490, 40);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(49, 15);
            lblSpecies.TabIndex = 5;
            lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(490, 65);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(190, 23);
            txtSpecies.TabIndex = 6;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(30, 115);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(30, 140);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(190, 23);
            txtAge.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(260, 140);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(190, 23);
            txtScore.TabIndex = 9;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(260, 115);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(90, 15);
            lblScore.TabIndex = 10;
            lblScore.Text = "Recovery Score:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 45);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD ANIMAL";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(260, 210);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(190, 45);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(490, 210);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 45);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "SAVE CHANGES";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(720, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 45);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE ANIMAL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewSummary
            // 
            btnViewSummary.Location = new Point(30, 541);
            btnViewSummary.Name = "btnViewSummary";
            btnViewSummary.Size = new Size(880, 49);
            btnViewSummary.TabIndex = 15;
            btnViewSummary.Text = "VIEW SUMMARY REPORT";
            btnViewSummary.UseVisualStyleBackColor = true;
            btnViewSummary.Click += btnViewSummary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 592);
            Controls.Add(btnViewSummary);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(lblScore);
            Controls.Add(txtScore);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtSpecies);
            Controls.Add(lblSpecies);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtAnimalId);
            Controls.Add(lblAnimalId);
            Controls.Add(dgvAnimals);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baobab Ridge - Animal Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAnimals;
        private Label lblAnimalId;
        private TextBox txtAnimalId;
        private Label lblName;
        private TextBox txtName;
        private Label lblSpecies;
        private TextBox txtSpecies;
        private Label lblAge;
        private TextBox txtAge;
        private TextBox txtScore;
        private Label lblScore;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnViewSummary;
    }
}
