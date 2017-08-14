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
            this.TxtBoxBMIScale = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CalculateBMI = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.04805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.95195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxBMIScale, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblHeight, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblWeight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxResult, 1, 2);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.82456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 323);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtBoxBMIScale
            // 
            this.TxtBoxBMIScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxBMIScale.Location = new System.Drawing.Point(3, 231);
            this.TxtBoxBMIScale.Multiline = true;
            this.TxtBoxBMIScale.Name = "TxtBoxBMIScale";
            this.TxtBoxBMIScale.Size = new System.Drawing.Size(143, 44);
            this.TxtBoxBMIScale.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CalculateBMI);
            this.panel3.Location = new System.Drawing.Point(152, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 89);
            this.panel3.TabIndex = 3;
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Location = new System.Drawing.Point(0, 0);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(140, 76);
            this.CalculateBMI.TabIndex = 3;
            this.CalculateBMI.Text = "Calculate BMI!";
            this.CalculateBMI.UseVisualStyleBackColor = true;
            this.CalculateBMI.Click += new System.EventHandler(this.CalculateBMI_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtBoxWeight);
            this.panel2.Controls.Add(this.LblWMeasurement);
            this.panel2.Location = new System.Drawing.Point(152, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 62);
            this.panel2.TabIndex = 3;
            // 
            // TxtBoxWeight
            // 
            this.TxtBoxWeight.Location = new System.Drawing.Point(0, 0);
            this.TxtBoxWeight.Name = "TxtBoxWeight";
            this.TxtBoxWeight.Size = new System.Drawing.Size(97, 38);
            this.TxtBoxWeight.TabIndex = 6;
            // 
            // LblWMeasurement
            // 
            this.LblWMeasurement.AutoSize = true;
            this.LblWMeasurement.Location = new System.Drawing.Point(3, 34);
            this.LblWMeasurement.Name = "LblWMeasurement";
            this.LblWMeasurement.Size = new System.Drawing.Size(0, 31);
            this.LblWMeasurement.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtBoxHeight);
            this.panel1.Controls.Add(this.LblMeasurement);
            this.panel1.Location = new System.Drawing.Point(152, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 75);
            this.panel1.TabIndex = 3;
            // 
            // TxtBoxHeight
            // 
            this.TxtBoxHeight.Location = new System.Drawing.Point(3, 3);
            this.TxtBoxHeight.Name = "TxtBoxHeight";
            this.TxtBoxHeight.Size = new System.Drawing.Size(94, 38);
            this.TxtBoxHeight.TabIndex = 4;
            // 
            // LblMeasurement
            // 
            this.LblMeasurement.AutoSize = true;
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
            this.LblHeight.Size = new System.Drawing.Size(136, 31);
            this.LblHeight.TabIndex = 3;
            this.LblHeight.Text = "My Height";
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Location = new System.Drawing.Point(3, 84);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(141, 31);
            this.LblWeight.TabIndex = 5;
            this.LblWeight.Text = "My Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your BMI:";
            // 
            // TxtBoxResult
            // 
            this.TxtBoxResult.Location = new System.Drawing.Point(152, 155);
            this.TxtBoxResult.Name = "TxtBoxResult";
            this.TxtBoxResult.Size = new System.Drawing.Size(97, 38);
            this.TxtBoxResult.TabIndex = 8;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(12, 53);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(270, 35);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial Calculation";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.Click += new System.EventHandler(this.ImperialButton_Click);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Location = new System.Drawing.Point(12, 12);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(248, 35);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric Calculation";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.Click += new System.EventHandler(this.MetricButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
    }
}

