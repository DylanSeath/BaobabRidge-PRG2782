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
            dgvAnimals.Location = new Point(34, 427);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(1006, 275);
            dgvAnimals.TabIndex = 0;
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Location = new Point(34, 53);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(78, 20);
            lblAnimalId.TabIndex = 1;
            lblAnimalId.Text = "Animal ID:";
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(34, 87);
            txtAnimalId.Margin = new Padding(3, 4, 3, 4);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(217, 27);
            txtAnimalId.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(297, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(297, 87);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 27);
            txtName.TabIndex = 4;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(560, 53);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(62, 20);
            lblSpecies.TabIndex = 5;
            lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(560, 87);
            txtSpecies.Margin = new Padding(3, 4, 3, 4);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(217, 27);
            txtSpecies.TabIndex = 6;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(34, 153);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(34, 187);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(217, 27);
            txtAge.TabIndex = 8;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(297, 187);
            txtScore.Margin = new Padding(3, 4, 3, 4);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(217, 27);
            txtScore.TabIndex = 9;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(297, 153);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(113, 20);
            lblScore.TabIndex = 10;
            lblScore.Text = "Recovery Score:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(34, 280);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(217, 60);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "ADD ANIMAL";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(297, 280);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(217, 60);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(560, 280);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(217, 60);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "SAVE CHANGES";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(823, 280);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(217, 60);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE ANIMAL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewSummary
            // 
            btnViewSummary.Location = new Point(34, 721);
            btnViewSummary.Margin = new Padding(3, 4, 3, 4);
            btnViewSummary.Name = "btnViewSummary";
            btnViewSummary.Size = new Size(1006, 65);
            btnViewSummary.TabIndex = 15;
            btnViewSummary.Text = "VIEW SUMMARY REPORT";
            btnViewSummary.UseVisualStyleBackColor = true;
            btnViewSummary.Click += btnViewSummary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 789);
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

