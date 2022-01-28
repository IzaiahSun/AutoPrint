namespace AutoPrint
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
            this.comboBoxPrinter = new System.Windows.Forms.ComboBox();
            this.labelPrinter = new System.Windows.Forms.Label();
            this.txtMonitorPath = new System.Windows.Forms.TextBox();
            this.btnChooseDir = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.richTextLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBoxPrinter
            // 
            this.comboBoxPrinter.FormattingEnabled = true;
            this.comboBoxPrinter.Location = new System.Drawing.Point(132, 25);
            this.comboBoxPrinter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPrinter.Name = "comboBoxPrinter";
            this.comboBoxPrinter.Size = new System.Drawing.Size(273, 25);
            this.comboBoxPrinter.TabIndex = 0;
            this.comboBoxPrinter.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrinter_SelectedIndexChanged);
            // 
            // labelPrinter
            // 
            this.labelPrinter.AutoSize = true;
            this.labelPrinter.Location = new System.Drawing.Point(15, 26);
            this.labelPrinter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrinter.Name = "labelPrinter";
            this.labelPrinter.Size = new System.Drawing.Size(95, 17);
            this.labelPrinter.TabIndex = 1;
            this.labelPrinter.Text = "Select a Printer";
            // 
            // txtMonitorPath
            // 
            this.txtMonitorPath.Location = new System.Drawing.Point(132, 67);
            this.txtMonitorPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonitorPath.Name = "txtMonitorPath";
            this.txtMonitorPath.ReadOnly = true;
            this.txtMonitorPath.Size = new System.Drawing.Size(188, 23);
            this.txtMonitorPath.TabIndex = 2;
            // 
            // btnChooseDir
            // 
            this.btnChooseDir.Location = new System.Drawing.Point(330, 66);
            this.btnChooseDir.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseDir.Name = "btnChooseDir";
            this.btnChooseDir.Size = new System.Drawing.Size(75, 25);
            this.btnChooseDir.TabIndex = 3;
            this.btnChooseDir.Text = "Choose";
            this.btnChooseDir.UseVisualStyleBackColor = true;
            this.btnChooseDir.Click += new System.EventHandler(this.btnChooseDir_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(15, 69);
            this.labelPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(100, 17);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Path to Monitor";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 114);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(391, 25);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // richTextLog
            // 
            this.richTextLog.Location = new System.Drawing.Point(15, 154);
            this.richTextLog.Margin = new System.Windows.Forms.Padding(2);
            this.richTextLog.Name = "richTextLog";
            this.richTextLog.ReadOnly = true;
            this.richTextLog.Size = new System.Drawing.Size(390, 172);
            this.richTextLog.TabIndex = 6;
            this.richTextLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 336);
            this.Controls.Add(this.richTextLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.btnChooseDir);
            this.Controls.Add(this.txtMonitorPath);
            this.Controls.Add(this.labelPrinter);
            this.Controls.Add(this.comboBoxPrinter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Monitor and Print";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxPrinter;
        private Label labelPrinter;
        private TextBox txtMonitorPath;
        private Button btnChooseDir;
        private Label labelPath;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnStart;
        private RichTextBox richTextLog;
    }
}