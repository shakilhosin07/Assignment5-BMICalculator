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
            this.LblHeight = new System.Windows.Forms.Label();
            this.TxtBoxHeight = new System.Windows.Forms.TextBox();
            this.LblWeight = new System.Windows.Forms.Label();
            this.TxtBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxResult = new System.Windows.Forms.TextBox();
            this.LblMeasurement = new System.Windows.Forms.Label();
            this.LblWMeasurement = new System.Windows.Forms.Label();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.TxtBoxBMIScale = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.78577F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.21422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.Controls.Add(this.LblHeight, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxHeight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblWeight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxWeight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtBoxResult, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblMeasurement, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblWMeasurement, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(70, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.51089F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.15578F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 281);
            this.tableLayoutPanel1.TabIndex = 0;
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
            // TxtBoxHeight
            // 
            this.TxtBoxHeight.Location = new System.Drawing.Point(226, 3);
            this.TxtBoxHeight.Name = "TxtBoxHeight";
            this.TxtBoxHeight.Size = new System.Drawing.Size(219, 38);
            this.TxtBoxHeight.TabIndex = 4;
            // 
            // LblWeight
            // 
            this.LblWeight.AutoSize = true;
            this.LblWeight.Location = new System.Drawing.Point(3, 99);
            this.LblWeight.Name = "LblWeight";
            this.LblWeight.Size = new System.Drawing.Size(141, 31);
            this.LblWeight.TabIndex = 5;
            this.LblWeight.Text = "My Weight";
            // 
            // TxtBoxWeight
            // 
            this.TxtBoxWeight.Location = new System.Drawing.Point(226, 102);
            this.TxtBoxWeight.Name = "TxtBoxWeight";
            this.TxtBoxWeight.Size = new System.Drawing.Size(219, 38);
            this.TxtBoxWeight.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your BMI:";
            // 
            // TxtBoxResult
            // 
            this.TxtBoxResult.Location = new System.Drawing.Point(226, 189);
            this.TxtBoxResult.Name = "TxtBoxResult";
            this.TxtBoxResult.Size = new System.Drawing.Size(219, 38);
            this.TxtBoxResult.TabIndex = 8;
            // 
            // LblMeasurement
            // 
            this.LblMeasurement.AutoSize = true;
            this.LblMeasurement.Location = new System.Drawing.Point(451, 0);
            this.LblMeasurement.Name = "LblMeasurement";
            this.LblMeasurement.Size = new System.Drawing.Size(0, 31);
            this.LblMeasurement.TabIndex = 9;
            // 
            // LblWMeasurement
            // 
            this.LblWMeasurement.AutoSize = true;
            this.LblWMeasurement.Location = new System.Drawing.Point(451, 99);
            this.LblWMeasurement.Name = "LblWMeasurement";
            this.LblWMeasurement.Size = new System.Drawing.Size(0, 31);
            this.LblWMeasurement.TabIndex = 10;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(70, 53);
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
            this.MetricButton.Location = new System.Drawing.Point(70, 12);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(248, 35);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric Calculation";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.Click += new System.EventHandler(this.MetricButton_Click);
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Location = new System.Drawing.Point(70, 408);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(299, 54);
            this.CalculateBMI.TabIndex = 3;
            this.CalculateBMI.Text = "Calculate My BMI!";
            this.CalculateBMI.UseVisualStyleBackColor = true;
            this.CalculateBMI.Click += new System.EventHandler(this.CalculateBMI_Click);
            // 
            // TxtBoxBMIScale
            // 
            this.TxtBoxBMIScale.Location = new System.Drawing.Point(421, 431);
            this.TxtBoxBMIScale.Multiline = true;
            this.TxtBoxBMIScale.Name = "TxtBoxBMIScale";
            this.TxtBoxBMIScale.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxBMIScale.TabIndex = 4;
            this.TxtBoxBMIScale.TextChanged += new System.EventHandler(this.TxtBoxBMIScale_TextChanged);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 741);
            this.Controls.Add(this.TxtBoxBMIScale);
            this.Controls.Add(this.CalculateBMI);
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
    }
}

