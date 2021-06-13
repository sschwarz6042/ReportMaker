namespace ReportMaker
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
            this.ComponentButton = new System.Windows.Forms.Button();
            this.ExcelFilePathLabel = new System.Windows.Forms.Label();
            this.ExcelFilePathTextBox = new System.Windows.Forms.TextBox();
            this.ExcelFilePathButton = new System.Windows.Forms.Button();
            this.OutputDirectoryPathLabel = new System.Windows.Forms.Label();
            this.OutputDirectoryPathTextBox = new System.Windows.Forms.TextBox();
            this.OutputDirectoryPathButton = new System.Windows.Forms.Button();
            this.CreateFromExcelButton = new System.Windows.Forms.Button();
            this.CreateManyLabel = new System.Windows.Forms.Label();
            this.CustomReportLabel = new System.Windows.Forms.Label();
            this.ReportNameLabel = new System.Windows.Forms.Label();
            this.CustomReportNameTextBox = new System.Windows.Forms.TextBox();
            this.ReportIDLabel = new System.Windows.Forms.Label();
            this.ReportIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomReportParameterLabel = new System.Windows.Forms.Label();
            this.ParamterPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComponentButton
            // 
            this.ComponentButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComponentButton.Location = new System.Drawing.Point(598, 414);
            this.ComponentButton.Name = "ComponentButton";
            this.ComponentButton.Size = new System.Drawing.Size(234, 47);
            this.ComponentButton.TabIndex = 0;
            this.ComponentButton.Text = "Create Component";
            this.ComponentButton.UseVisualStyleBackColor = true;
            this.ComponentButton.Click += new System.EventHandler(this.ComponentButton_Click);
            // 
            // ExcelFilePathLabel
            // 
            this.ExcelFilePathLabel.AutoSize = true;
            this.ExcelFilePathLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcelFilePathLabel.Location = new System.Drawing.Point(88, 64);
            this.ExcelFilePathLabel.Name = "ExcelFilePathLabel";
            this.ExcelFilePathLabel.Size = new System.Drawing.Size(163, 31);
            this.ExcelFilePathLabel.TabIndex = 1;
            this.ExcelFilePathLabel.Text = "Excel File Path:";
            // 
            // ExcelFilePathTextBox
            // 
            this.ExcelFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcelFilePathTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ExcelFilePathTextBox.Location = new System.Drawing.Point(269, 57);
            this.ExcelFilePathTextBox.Name = "ExcelFilePathTextBox";
            this.ExcelFilePathTextBox.Size = new System.Drawing.Size(312, 38);
            this.ExcelFilePathTextBox.TabIndex = 2;
            this.ExcelFilePathTextBox.Text = "C:\\";
            // 
            // ExcelFilePathButton
            // 
            this.ExcelFilePathButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcelFilePathButton.Location = new System.Drawing.Point(610, 57);
            this.ExcelFilePathButton.Name = "ExcelFilePathButton";
            this.ExcelFilePathButton.Size = new System.Drawing.Size(129, 38);
            this.ExcelFilePathButton.TabIndex = 3;
            this.ExcelFilePathButton.Text = "Find File";
            this.ExcelFilePathButton.UseVisualStyleBackColor = true;
            this.ExcelFilePathButton.Click += new System.EventHandler(this.ExcelFilePathButton_Click);
            // 
            // OutputDirectoryPathLabel
            // 
            this.OutputDirectoryPathLabel.AutoSize = true;
            this.OutputDirectoryPathLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputDirectoryPathLabel.Location = new System.Drawing.Point(9, 134);
            this.OutputDirectoryPathLabel.Name = "OutputDirectoryPathLabel";
            this.OutputDirectoryPathLabel.Size = new System.Drawing.Size(242, 31);
            this.OutputDirectoryPathLabel.TabIndex = 1;
            this.OutputDirectoryPathLabel.Text = "Output Directory Path:";
            // 
            // OutputDirectoryPathTextBox
            // 
            this.OutputDirectoryPathTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputDirectoryPathTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.OutputDirectoryPathTextBox.Location = new System.Drawing.Point(269, 127);
            this.OutputDirectoryPathTextBox.Name = "OutputDirectoryPathTextBox";
            this.OutputDirectoryPathTextBox.Size = new System.Drawing.Size(312, 38);
            this.OutputDirectoryPathTextBox.TabIndex = 2;
            this.OutputDirectoryPathTextBox.Text = "C:\\";
            // 
            // OutputDirectoryPathButton
            // 
            this.OutputDirectoryPathButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputDirectoryPathButton.Location = new System.Drawing.Point(610, 127);
            this.OutputDirectoryPathButton.Name = "OutputDirectoryPathButton";
            this.OutputDirectoryPathButton.Size = new System.Drawing.Size(202, 38);
            this.OutputDirectoryPathButton.TabIndex = 3;
            this.OutputDirectoryPathButton.Text = "Select Directory";
            this.OutputDirectoryPathButton.UseVisualStyleBackColor = true;
            this.OutputDirectoryPathButton.Click += new System.EventHandler(this.OutputDirectoryPathButton_Click);
            // 
            // CreateFromExcelButton
            // 
            this.CreateFromExcelButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateFromExcelButton.Location = new System.Drawing.Point(197, 186);
            this.CreateFromExcelButton.Name = "CreateFromExcelButton";
            this.CreateFromExcelButton.Size = new System.Drawing.Size(451, 57);
            this.CreateFromExcelButton.TabIndex = 4;
            this.CreateFromExcelButton.Text = "Create Components From Excel";
            this.CreateFromExcelButton.UseVisualStyleBackColor = true;
            this.CreateFromExcelButton.Click += new System.EventHandler(this.CreateFromExcelButton_Click);
            // 
            // CreateManyLabel
            // 
            this.CreateManyLabel.AutoSize = true;
            this.CreateManyLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateManyLabel.Location = new System.Drawing.Point(239, 9);
            this.CreateManyLabel.Name = "CreateManyLabel";
            this.CreateManyLabel.Size = new System.Drawing.Size(374, 31);
            this.CreateManyLabel.TabIndex = 5;
            this.CreateManyLabel.Text = "Automatically Create Many Reports";
            // 
            // CustomReportLabel
            // 
            this.CustomReportLabel.AutoSize = true;
            this.CustomReportLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomReportLabel.Location = new System.Drawing.Point(251, 314);
            this.CustomReportLabel.Name = "CustomReportLabel";
            this.CustomReportLabel.Size = new System.Drawing.Size(341, 31);
            this.CustomReportLabel.TabIndex = 5;
            this.CustomReportLabel.Text = "Manually Create a Single Report";
            // 
            // ReportNameLabel
            // 
            this.ReportNameLabel.AutoSize = true;
            this.ReportNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReportNameLabel.Location = new System.Drawing.Point(23, 365);
            this.ReportNameLabel.Name = "ReportNameLabel";
            this.ReportNameLabel.Size = new System.Drawing.Size(154, 31);
            this.ReportNameLabel.TabIndex = 1;
            this.ReportNameLabel.Text = "Report Name:";
            // 
            // CustomReportNameTextBox
            // 
            this.CustomReportNameTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomReportNameTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CustomReportNameTextBox.Location = new System.Drawing.Point(197, 358);
            this.CustomReportNameTextBox.Name = "CustomReportNameTextBox";
            this.CustomReportNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CustomReportNameTextBox.Size = new System.Drawing.Size(312, 38);
            this.CustomReportNameTextBox.TabIndex = 2;
            this.CustomReportNameTextBox.Text = "Custom Report";
            // 
            // ReportIDLabel
            // 
            this.ReportIDLabel.AutoSize = true;
            this.ReportIDLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReportIDLabel.Location = new System.Drawing.Point(62, 423);
            this.ReportIDLabel.Name = "ReportIDLabel";
            this.ReportIDLabel.Size = new System.Drawing.Size(115, 31);
            this.ReportIDLabel.TabIndex = 1;
            this.ReportIDLabel.Text = "Report ID:";
            // 
            // ReportIDTextBox
            // 
            this.ReportIDTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReportIDTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ReportIDTextBox.Location = new System.Drawing.Point(197, 423);
            this.ReportIDTextBox.Name = "ReportIDTextBox";
            this.ReportIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ReportIDTextBox.Size = new System.Drawing.Size(312, 38);
            this.ReportIDTextBox.TabIndex = 2;
            this.ReportIDTextBox.Text = "309";
            // 
            // CustomReportParameterLabel
            // 
            this.CustomReportParameterLabel.AutoSize = true;
            this.CustomReportParameterLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomReportParameterLabel.Location = new System.Drawing.Point(239, 479);
            this.CustomReportParameterLabel.Name = "CustomReportParameterLabel";
            this.CustomReportParameterLabel.Size = new System.Drawing.Size(286, 31);
            this.CustomReportParameterLabel.TabIndex = 5;
            this.CustomReportParameterLabel.Text = "Custom Report Parameters";
            // 
            // ParamterPanel
            // 
            this.ParamterPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParamterPanel.Location = new System.Drawing.Point(23, 543);
            this.ParamterPanel.Name = "ParamterPanel";
            this.ParamterPanel.Size = new System.Drawing.Size(625, 185);
            this.ParamterPanel.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(692, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 92);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Parameter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ParamterPanel);
            this.Controls.Add(this.CustomReportParameterLabel);
            this.Controls.Add(this.ReportIDTextBox);
            this.Controls.Add(this.ReportIDLabel);
            this.Controls.Add(this.CustomReportNameTextBox);
            this.Controls.Add(this.ReportNameLabel);
            this.Controls.Add(this.CustomReportLabel);
            this.Controls.Add(this.CreateManyLabel);
            this.Controls.Add(this.CreateFromExcelButton);
            this.Controls.Add(this.OutputDirectoryPathButton);
            this.Controls.Add(this.OutputDirectoryPathTextBox);
            this.Controls.Add(this.OutputDirectoryPathLabel);
            this.Controls.Add(this.ExcelFilePathButton);
            this.Controls.Add(this.ExcelFilePathTextBox);
            this.Controls.Add(this.ExcelFilePathLabel);
            this.Controls.Add(this.ComponentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComponentButton;
        private System.Windows.Forms.Label ExcelFilePathLabel;
        private System.Windows.Forms.TextBox ExcelFilePathTextBox;
        private System.Windows.Forms.Button ExcelFilePathButton;
        private System.Windows.Forms.Label OutputDirectoryPathLabel;
        private System.Windows.Forms.TextBox OutputDirectoryPathTextBox;
        private System.Windows.Forms.Button OutputDirectoryPathButton;
        private System.Windows.Forms.Button CreateFromExcelButton;
        private System.Windows.Forms.Label CreateManyLabel;
        private System.Windows.Forms.Label CustomReportLabel;
        private System.Windows.Forms.Label ReportNameLabel;
        private System.Windows.Forms.TextBox CustomReportNameTextBox;
        private System.Windows.Forms.Label ReportIDLabel;
        private System.Windows.Forms.TextBox ReportIDTextBox;
        private System.Windows.Forms.Label CustomReportParameterLabel;
        private System.Windows.Forms.Panel ParamterPanel;
        private System.Windows.Forms.Button button1;
    }
}

