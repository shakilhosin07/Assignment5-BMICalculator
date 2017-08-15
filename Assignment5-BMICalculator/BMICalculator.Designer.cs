namespace Assignment5_BMICalculator
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.TxtBoxBMIScale = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtBoxWeight = new System.Windows.Forms.TextBox();
            this.LblWMeasurement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtBoxHeight = new System.Windows.Forms.TextBox();
            this.LblMeasurement = new System.Windows.Forms.Label();
            this.LblHeight = new System.Windows.Forms.Label();
            this.LblWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxResult = new System.Windows.Forms.TextBox();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.04805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.95195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblHeight, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblWeight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxResult, 1, 2);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.82456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(303, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.CalculateBMI);
            this.panel4.Controls.Add(this.TxtBoxBMIScale);
            this.panel4.Location = new System.Drawing.Point(3, 247);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 88);
            this.panel4.TabIndex = 4;
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMI.Location = new System.Drawing.Point(5, 3);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(131, 45);
            this.CalculateBMI.TabIndex = 3;
            this.CalculateBMI.Text = "Calculate BMI!";
            this.CalculateBMI.UseVisualStyleBackColor = true;
            this.CalculateBMI.Click += new System.EventHandler(this.CalculateBMI_Click);
            // 
            // TxtBoxBMIScale
            // 
            this.TxtBoxBMIScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxBMIScale.Location = new System.Drawing.Point(0, 53);
            this.TxtBoxBMIScale.Multiline = true;
            this.TxtBoxBMIScale.Name = "TxtBoxBMIScale";
            this.TxtBoxBMIScale.Size = new System.Drawing.Size(139, 32);
            this.TxtBoxBMIScale.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ResetButton);
            this.panel3.Controls.Add(this.BMIProgressBar);
            this.panel3.Location = new System.Drawing.Point(148, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 88);
            this.panel3.TabIndex = 3;
            // 
            // BMIProgressBar
            // 
            this.BMIProgressBar.Location = new System.Drawing.Point(0, 26);
            this.BMIProgressBar.Maximum = 30;
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(152, 22);
            this.BMIProgressBar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtBoxWeight);
            this.panel2.Controls.Add(this.LblWMeasurement);
            this.panel2.Location = new System.Drawing.Point(148, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 67);
            this.panel2.TabIndex = 3;
            // 
            // TxtBoxWeight
            // 
            this.TxtBoxWeight.Location = new System.Drawing.Point(0, 0);
            this.TxtBoxWeight.Name = "TxtBoxWeight";
            this.TxtBoxWeight.Size = new System.Drawing.Size(91, 39);
            this.TxtBoxWeight.TabIndex = 6;
            // 
            // LblWMeasurement
            // 
            this.LblWMeasurement.AutoSize = true;
            this.LblWMeasurement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblWMeasurement.Location = new System.Drawing.Point(3, 34);
            this.LblWMeasurement.Name = "LblWMeasurement";
            this.LblWMeasurement.Size = new System.Drawing.Size(0, 31);
            this.LblWMeasurement.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtBoxHeight);
            this.panel1.Controls.Add(this.LblMeasurement);
            this.panel1.Location = new System.Drawing.Point(148, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 75);
            this.panel1.TabIndex = 3;
            // 
            // TxtBoxHeight
            // 
            this.TxtBoxHeight.Location = new System.Drawing.Point(3, 3);
            this.TxtBoxHeight.Name = "TxtBoxHeight";
            this.TxtBoxHeight.Size = new System.Drawing.Size(88, 39);
            this.TxtBoxHeight.TabIndex = 4;
            // 
            // LblMeasurement
            // 
            this.LblMeasurement.AutoSize = true;
            this.LblMeasurement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblMeasurement.Location = new System.Drawing.Point(3, 39);
            this.LblMeasurement.Name = "LblMeasurement";
            this.LblMeasurement.Size = new System.Drawing.Size(0, 31);
            this.LblMeasurement.TabIndex = 9;
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(3, 0);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(130, 31);
            this.LblHeight.TabIndex = 3;
            this.LblHeight.Text = "My Height";
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Location = new System.Drawing.Point(3, 90);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(134, 31);
            this.LblWeight.TabIndex = 5;
            this.LblWeight.Text = "My Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your BMI:";
            // 
            // TxtBoxResult
            // 
            this.TxtBoxResult.Location = new System.Drawing.Point(148, 166);
            this.TxtBoxResult.Name = "TxtBoxResult";
            this.TxtBoxResult.Size = new System.Drawing.Size(91, 39);
            this.TxtBoxResult.TabIndex = 8;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(21, 68);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(256, 35);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial Calculation";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.Click += new System.EventHandler(this.ImperialButton_Click);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Location = new System.Drawing.Point(21, 40);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(238, 35);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric Calculation";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.Click += new System.EventHandler(this.MetricButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleLabel.Location = new System.Drawing.Point(26, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(249, 29);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "BMI CALCULATOR";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(16, 53);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(113, 32);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.TextBox TxtBoxHeight;
        private System.Windows.Forms.Label LblWeight;
        private System.Windows.Forms.TextBox TxtBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxResult;
        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.Label LblMeasurement;
        private System.Windows.Forms.Label LblWMeasurement;
        private System.Windows.Forms.TextBox TxtBoxBMIScale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
        private System.Windows.Forms.Button ResetButton;
    }
}

