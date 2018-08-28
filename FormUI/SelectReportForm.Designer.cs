namespace FormUI
{
    partial class SelectReportForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ReportTitleLabel = new System.Windows.Forms.Label();
            this.RunReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // ReportTitleLabel
            // 
            this.ReportTitleLabel.AutoSize = true;
            this.ReportTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.ReportTitleLabel.Name = "ReportTitleLabel";
            this.ReportTitleLabel.Size = new System.Drawing.Size(209, 45);
            this.ReportTitleLabel.TabIndex = 1;
            this.ReportTitleLabel.Text = "Select Report";
            // 
            // RunReportButton
            // 
            this.RunReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunReportButton.Location = new System.Drawing.Point(21, 121);
            this.RunReportButton.Name = "RunReportButton";
            this.RunReportButton.Size = new System.Drawing.Size(89, 33);
            this.RunReportButton.TabIndex = 2;
            this.RunReportButton.Text = "Run";
            this.RunReportButton.UseVisualStyleBackColor = true;
            // 
            // SelectReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 353);
            this.Controls.Add(this.RunReportButton);
            this.Controls.Add(this.ReportTitleLabel);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SelectReportForm";
            this.Text = "Select Report";
            this.Load += new System.EventHandler(this.SelectReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ReportTitleLabel;
        private System.Windows.Forms.Button RunReportButton;
    }
}