namespace FormUI
{
    partial class ReportForm
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
            this.ReportListView = new System.Windows.Forms.ListView();
            this.ReportTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReportListView
            // 
            this.ReportListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportListView.Location = new System.Drawing.Point(12, 60);
            this.ReportListView.Name = "ReportListView";
            this.ReportListView.Size = new System.Drawing.Size(584, 448);
            this.ReportListView.TabIndex = 0;
            this.ReportListView.UseCompatibleStateImageBehavior = false;
            this.ReportListView.View = System.Windows.Forms.View.Details;
            // 
            // ReportTitle
            // 
            this.ReportTitle.AutoSize = true;
            this.ReportTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTitle.Location = new System.Drawing.Point(12, 9);
            this.ReportTitle.Name = "ReportTitle";
            this.ReportTitle.Size = new System.Drawing.Size(240, 45);
            this.ReportTitle.TabIndex = 1;
            this.ReportTitle.Text = "<report name>";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 539);
            this.Controls.Add(this.ReportTitle);
            this.Controls.Add(this.ReportListView);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ReportListView;
        private System.Windows.Forms.Label ReportTitle;
    }
}