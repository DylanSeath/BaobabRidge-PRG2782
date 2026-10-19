namespace BaobaRidge
{
    partial class SummaryForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlTotalAnimals = new Panel();
            lblTotalAnimalTitle = new Label();
            lblTotalAnimalsValue = new Label();
            pnlAverageAge = new Panel();
            lblAverageAgeValue = new Label();
            lblAverageAgeTitle = new Label();
            pnlAverageScore = new Panel();
            lblAverageScoreValue = new Label();
            lblAverageScoreTitle = new Label();
            pnlStatusCounts = new Panel();
            lblStatusTitle = new Label();
            lblCriticalTitle = new Label();
            lblCriticalValue = new Label();
            lblSeriousTitle = new Label();
            lblStableTitle = new Label();
            lblRecoveringTitle = new Label();
            lblReleaseReadyTitle = new Label();
            lblSeriousValue = new Label();
            lblStableValue = new Label();
            lblRecoveringValue = new Label();
            lblReleaseReadyValue = new Label();
            btnGenerateSummary = new Button();
            pnlHeader.SuspendLayout();
            pnlTotalAnimals.SuspendLayout();
            pnlAverageAge.SuspendLayout();
            pnlAverageScore.SuspendLayout();
            pnlStatusCounts.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Navy;
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(884, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(213, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BAOBAB RIDGE";

            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(28, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(245, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Wildlife Rehabilitation - Summary Report";
            // 
            // pnlTotalAnimals
            // 
            pnlTotalAnimals.BackColor = Color.White;
            pnlTotalAnimals.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalAnimals.Controls.Add(lblTotalAnimalsValue);
            pnlTotalAnimals.Controls.Add(lblTotalAnimalTitle);
            pnlTotalAnimals.Location = new Point(25, 130);
            pnlTotalAnimals.Name = "pnlTotalAnimals";
            pnlTotalAnimals.Size = new Size(250, 120);
            pnlTotalAnimals.TabIndex = 1;
            // 
            // lblTotalAnimalTitle
            // 
            lblTotalAnimalTitle.AutoSize = true;
            lblTotalAnimalTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAnimalTitle.ForeColor = Color.DarkBlue;
            lblTotalAnimalTitle.Location = new Point(20, 15);
            lblTotalAnimalTitle.Name = "lblTotalAnimalTitle";
            lblTotalAnimalTitle.Size = new Size(127, 20);
            lblTotalAnimalTitle.TabIndex = 0;
            lblTotalAnimalTitle.Text = "TOTAL ANIMALS";
            // 
            // lblTotalAnimalsValue
            // 
            lblTotalAnimalsValue.AutoSize = true;
            lblTotalAnimalsValue.BackColor = Color.White;
            lblTotalAnimalsValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAnimalsValue.ForeColor = Color.DarkBlue;
            lblTotalAnimalsValue.Location = new Point(20, 48);
            lblTotalAnimalsValue.Name = "lblTotalAnimalsValue";
            lblTotalAnimalsValue.Size = new Size(25, 30);
            lblTotalAnimalsValue.TabIndex = 2;
            lblTotalAnimalsValue.Text = "0";
            // 
            // pnlAverageAge
            // 
            pnlAverageAge.BackColor = Color.White;
            pnlAverageAge.BorderStyle = BorderStyle.FixedSingle;
            pnlAverageAge.Controls.Add(lblAverageAgeValue);
            pnlAverageAge.Controls.Add(lblAverageAgeTitle);
            pnlAverageAge.Location = new Point(325, 130);
            pnlAverageAge.Name = "pnlAverageAge";
            pnlAverageAge.Size = new Size(250, 120);
            pnlAverageAge.TabIndex = 3;
            // 
            // lblAverageAgeValue
            // 
            lblAverageAgeValue.AutoSize = true;
            lblAverageAgeValue.BackColor = Color.White;
            lblAverageAgeValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageAgeValue.ForeColor = Color.DarkBlue;
            lblAverageAgeValue.Location = new Point(20, 48);
            lblAverageAgeValue.Name = "lblAverageAgeValue";
            lblAverageAgeValue.Size = new Size(54, 30);
            lblAverageAgeValue.TabIndex = 2;
            lblAverageAgeValue.Text = "N/A";
            // 
            // lblAverageAgeTitle
            // 
            lblAverageAgeTitle.AutoSize = true;
            lblAverageAgeTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageAgeTitle.ForeColor = Color.DarkBlue;
            lblAverageAgeTitle.Location = new Point(20, 15);
            lblAverageAgeTitle.Name = "lblAverageAgeTitle";
            lblAverageAgeTitle.Size = new Size(111, 20);
            lblAverageAgeTitle.TabIndex = 0;
            lblAverageAgeTitle.Text = "AVERAGE AGE";
            // 
            // pnlAverageScore
            // 
            pnlAverageScore.BackColor = Color.White;
            pnlAverageScore.BorderStyle = BorderStyle.FixedSingle;
            pnlAverageScore.Controls.Add(lblAverageScoreValue);
            pnlAverageScore.Controls.Add(lblAverageScoreTitle);
            pnlAverageScore.Location = new Point(25, 280);
            pnlAverageScore.Name = "pnlAverageScore";
            pnlAverageScore.Size = new Size(250, 120);
            pnlAverageScore.TabIndex = 4;
            // 
            // lblAverageScoreValue
            // 
            lblAverageScoreValue.AutoSize = true;
            lblAverageScoreValue.BackColor = Color.White;
            lblAverageScoreValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageScoreValue.ForeColor = Color.DarkBlue;
            lblAverageScoreValue.Location = new Point(20, 48);
            lblAverageScoreValue.Name = "lblAverageScoreValue";
            lblAverageScoreValue.Size = new Size(54, 30);
            lblAverageScoreValue.TabIndex = 2;
            lblAverageScoreValue.Text = "N/A";
            // 
            // lblAverageScoreTitle
            // 
            lblAverageScoreTitle.AutoSize = true;
            lblAverageScoreTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageScoreTitle.ForeColor = Color.DarkBlue;
            lblAverageScoreTitle.Location = new Point(20, 15);
            lblAverageScoreTitle.Name = "lblAverageScoreTitle";
            lblAverageScoreTitle.Size = new Size(206, 20);
            lblAverageScoreTitle.TabIndex = 0;
            lblAverageScoreTitle.Text = "AVERAGE RECOVERY SCORE";
            // 
            // pnlStatusCounts
            // 
            pnlStatusCounts.BackColor = Color.White;
            pnlStatusCounts.BorderStyle = BorderStyle.FixedSingle;
            pnlStatusCounts.Controls.Add(lblReleaseReadyValue);
            pnlStatusCounts.Controls.Add(lblRecoveringValue);
            pnlStatusCounts.Controls.Add(lblStableValue);
            pnlStatusCounts.Controls.Add(lblSeriousValue);
            pnlStatusCounts.Controls.Add(lblReleaseReadyTitle);
            pnlStatusCounts.Controls.Add(lblRecoveringTitle);
            pnlStatusCounts.Controls.Add(lblStableTitle);
            pnlStatusCounts.Controls.Add(lblSeriousTitle);
            pnlStatusCounts.Controls.Add(lblCriticalValue);
            pnlStatusCounts.Controls.Add(lblCriticalTitle);
            pnlStatusCounts.Controls.Add(lblStatusTitle);
            pnlStatusCounts.Location = new Point(325, 280);
            pnlStatusCounts.Name = "pnlStatusCounts";
            pnlStatusCounts.Size = new Size(250, 220);
            pnlStatusCounts.TabIndex = 5;
            // 
            // lblStatusTitle
            // 
            lblStatusTitle.AutoSize = true;
            lblStatusTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusTitle.ForeColor = Color.DarkBlue;
            lblStatusTitle.Location = new Point(15, 15);
            lblStatusTitle.Name = "lblStatusTitle";
            lblStatusTitle.Size = new Size(167, 20);
            lblStatusTitle.TabIndex = 0;
            lblStatusTitle.Text = "ANIMALS PER STATUS";
            // 
            // lblCriticalTitle
            // 
            lblCriticalTitle.AutoSize = true;
            lblCriticalTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCriticalTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblCriticalTitle.Location = new Point(20, 50);
            lblCriticalTitle.Name = "lblCriticalTitle";
            lblCriticalTitle.Size = new Size(47, 17);
            lblCriticalTitle.TabIndex = 1;
            lblCriticalTitle.Text = "Critical";
            // 
            // lblCriticalValue
            // 
            lblCriticalValue.AutoSize = true;
            lblCriticalValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriticalValue.ForeColor = Color.DarkBlue;
            lblCriticalValue.Location = new Point(205, 50);
            lblCriticalValue.Name = "lblCriticalValue";
            lblCriticalValue.Size = new Size(15, 17);
            lblCriticalValue.TabIndex = 2;
            lblCriticalValue.Text = "0";
            // 
            // lblSeriousTitle
            // 
            lblSeriousTitle.AutoSize = true;
            lblSeriousTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeriousTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblSeriousTitle.Location = new Point(20, 80);
            lblSeriousTitle.Name = "lblSeriousTitle";
            lblSeriousTitle.Size = new Size(51, 17);
            lblSeriousTitle.TabIndex = 3;
            lblSeriousTitle.Text = "Serious";
            // 
            // lblStableTitle
            // 
            lblStableTitle.AutoSize = true;
            lblStableTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStableTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblStableTitle.Location = new Point(20, 110);
            lblStableTitle.Name = "lblStableTitle";
            lblStableTitle.Size = new Size(44, 17);
            lblStableTitle.TabIndex = 4;
            lblStableTitle.Text = "Stable";
            // 
            // lblRecoveringTitle
            // 
            lblRecoveringTitle.AutoSize = true;
            lblRecoveringTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecoveringTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblRecoveringTitle.Location = new Point(20, 140);
            lblRecoveringTitle.Name = "lblRecoveringTitle";
            lblRecoveringTitle.Size = new Size(73, 17);
            lblRecoveringTitle.TabIndex = 5;
            lblRecoveringTitle.Text = "Recovering";
            // 
            // lblReleaseReadyTitle
            // 
            lblReleaseReadyTitle.AutoSize = true;
            lblReleaseReadyTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReleaseReadyTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblReleaseReadyTitle.Location = new Point(20, 170);
            lblReleaseReadyTitle.Name = "lblReleaseReadyTitle";
            lblReleaseReadyTitle.Size = new Size(94, 17);
            lblReleaseReadyTitle.TabIndex = 6;
            lblReleaseReadyTitle.Text = "Release-Ready";
            // 
            // lblSeriousValue
            // 
            lblSeriousValue.AutoSize = true;
            lblSeriousValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeriousValue.ForeColor = Color.DarkBlue;
            lblSeriousValue.Location = new Point(205, 80);
            lblSeriousValue.Name = "lblSeriousValue";
            lblSeriousValue.Size = new Size(15, 17);
            lblSeriousValue.TabIndex = 7;
            lblSeriousValue.Text = "0";
            // 
            // lblStableValue
            // 
            lblStableValue.AutoSize = true;
            lblStableValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStableValue.ForeColor = Color.DarkBlue;
            lblStableValue.Location = new Point(205, 110);
            lblStableValue.Name = "lblStableValue";
            lblStableValue.Size = new Size(15, 17);
            lblStableValue.TabIndex = 8;
            lblStableValue.Text = "0";
            // 
            // lblRecoveringValue
            // 
            lblRecoveringValue.AutoSize = true;
            lblRecoveringValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecoveringValue.ForeColor = Color.DarkBlue;
            lblRecoveringValue.Location = new Point(205, 140);
            lblRecoveringValue.Name = "lblRecoveringValue";
            lblRecoveringValue.Size = new Size(15, 17);
            lblRecoveringValue.TabIndex = 9;
            lblRecoveringValue.Text = "0";
            // 
            // lblReleaseReadyValue
            // 
            lblReleaseReadyValue.AutoSize = true;
            lblReleaseReadyValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReleaseReadyValue.ForeColor = Color.DarkBlue;
            lblReleaseReadyValue.Location = new Point(205, 170);
            lblReleaseReadyValue.Name = "lblReleaseReadyValue";
            lblReleaseReadyValue.Size = new Size(15, 17);
            lblReleaseReadyValue.TabIndex = 10;
            lblReleaseReadyValue.Text = "0";
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.BackColor = Color.MediumSeaGreen;
            btnGenerateSummary.FlatStyle = FlatStyle.Flat;
            btnGenerateSummary.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateSummary.ForeColor = Color.White;
            btnGenerateSummary.Location = new Point(25, 510);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(550, 50);
            btnGenerateSummary.TabIndex = 6;
            btnGenerateSummary.Text = "GENERATE SUMMARY";
            btnGenerateSummary.UseVisualStyleBackColor = false;
            btnGenerateSummary.Click += this.btnGenerateSummary_Click;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(884, 561);
            Controls.Add(btnGenerateSummary);
            Controls.Add(pnlStatusCounts);
            Controls.Add(pnlAverageScore);
            Controls.Add(pnlAverageAge);
            Controls.Add(pnlTotalAnimals);
            Controls.Add(pnlHeader);
            Name = "SummaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animal Summary Report";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlTotalAnimals.ResumeLayout(false);
            pnlTotalAnimals.PerformLayout();
            pnlAverageAge.ResumeLayout(false);
            pnlAverageAge.PerformLayout();
            pnlAverageScore.ResumeLayout(false);
            pnlAverageScore.PerformLayout();
            pnlStatusCounts.ResumeLayout(false);
            pnlStatusCounts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlTotalAnimals;
        private Label lblTotalAnimalTitle;
        private Label lblTotalAnimalsValue;
        private Panel pnlAverageAge;
        private Label lblAverageAgeValue;
        private Label lblAverageAgeTitle;
        private Panel pnlAverageScore;
        private Label lblAverageScoreValue;
        private Label lblAverageScoreTitle;
        private Panel pnlStatusCounts;
        private Label lblCriticalTitle;
        private Label lblStatusTitle;
        private Label lblCriticalValue;
        private Label lblReleaseReadyTitle;
        private Label lblRecoveringTitle;
        private Label lblStableTitle;
        private Label lblSeriousTitle;
        private Label lblSeriousValue;
        private Label lblReleaseReadyValue;
        private Label lblRecoveringValue;
        private Label lblStableValue;
        private Button btnGenerateSummary;
    }
}
