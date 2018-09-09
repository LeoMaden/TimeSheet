namespace FormUI
{
    partial class LogPayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PayDateSelector = new System.Windows.Forms.MonthCalendar();
            this.DateSelectedLabel = new System.Windows.Forms.Label();
            this.SelectedDateLabel = new System.Windows.Forms.Label();
            this.EmploymentLabel = new System.Windows.Forms.Label();
            this.EmploymentNameLabel = new System.Windows.Forms.Label();
            this.PayListViewBox = new System.Windows.Forms.ListView();
            this.DateCol1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoursWorkedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpectedPayCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActualPayCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddPaymentButton = new System.Windows.Forms.Button();
            this.HoursListViewBox = new System.Windows.Forms.ListView();
            this.DateCol2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LinkHoursPayButton = new System.Windows.Forms.Button();
            this.UnlinkHoursPayButton = new System.Windows.Forms.Button();
            this.DeletePaymentButton = new System.Windows.Forms.Button();
            this.ActualPayLabel = new System.Windows.Forms.Label();
            this.ActualPayTextBox = new System.Windows.Forms.TextBox();
            this.SetActualPayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log Pay Form";
            // 
            // PayDateSelector
            // 
            this.PayDateSelector.Location = new System.Drawing.Point(20, 63);
            this.PayDateSelector.MaxSelectionCount = 1;
            this.PayDateSelector.Name = "PayDateSelector";
            this.PayDateSelector.ShowWeekNumbers = true;
            this.PayDateSelector.TabIndex = 2;
            this.PayDateSelector.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.PayDateSelector_DateChanged);
            // 
            // DateSelectedLabel
            // 
            this.DateSelectedLabel.AutoSize = true;
            this.DateSelectedLabel.Location = new System.Drawing.Point(8, 234);
            this.DateSelectedLabel.Name = "DateSelectedLabel";
            this.DateSelectedLabel.Size = new System.Drawing.Size(146, 30);
            this.DateSelectedLabel.TabIndex = 3;
            this.DateSelectedLabel.Text = "Date Selected:";
            // 
            // SelectedDateLabel
            // 
            this.SelectedDateLabel.AutoSize = true;
            this.SelectedDateLabel.Location = new System.Drawing.Point(160, 234);
            this.SelectedDateLabel.Name = "SelectedDateLabel";
            this.SelectedDateLabel.Size = new System.Drawing.Size(125, 30);
            this.SelectedDateLabel.TabIndex = 4;
            this.SelectedDateLabel.Text = "XX/XX/XXXX";
            // 
            // EmploymentLabel
            // 
            this.EmploymentLabel.AutoSize = true;
            this.EmploymentLabel.Location = new System.Drawing.Point(789, 21);
            this.EmploymentLabel.Name = "EmploymentLabel";
            this.EmploymentLabel.Size = new System.Drawing.Size(134, 30);
            this.EmploymentLabel.TabIndex = 9;
            this.EmploymentLabel.Text = "Employment:";
            // 
            // EmploymentNameLabel
            // 
            this.EmploymentNameLabel.AutoSize = true;
            this.EmploymentNameLabel.Location = new System.Drawing.Point(929, 21);
            this.EmploymentNameLabel.Name = "EmploymentNameLabel";
            this.EmploymentNameLabel.Size = new System.Drawing.Size(157, 30);
            this.EmploymentNameLabel.TabIndex = 10;
            this.EmploymentNameLabel.Text = "<employment>";
            // 
            // PayListViewBox
            // 
            this.PayListViewBox.AllowDrop = true;
            this.PayListViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateCol1,
            this.HoursWorkedCol,
            this.ExpectedPayCol,
            this.ActualPayCol});
            this.PayListViewBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayListViewBox.FullRowSelect = true;
            this.PayListViewBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PayListViewBox.HideSelection = false;
            this.PayListViewBox.Location = new System.Drawing.Point(300, 77);
            this.PayListViewBox.MultiSelect = false;
            this.PayListViewBox.Name = "PayListViewBox";
            this.PayListViewBox.Size = new System.Drawing.Size(331, 242);
            this.PayListViewBox.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.PayListViewBox.TabIndex = 14;
            this.PayListViewBox.UseCompatibleStateImageBehavior = false;
            this.PayListViewBox.View = System.Windows.Forms.View.Details;
            this.PayListViewBox.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.PayListViewBox_ColumnWidthChanging);
            this.PayListViewBox.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.PayListViewBox_ItemSelectionChanged);
            // 
            // DateCol1
            // 
            this.DateCol1.Text = "Date";
            this.DateCol1.Width = 130;
            // 
            // HoursWorkedCol
            // 
            this.HoursWorkedCol.Text = "Hours";
            this.HoursWorkedCol.Width = 51;
            // 
            // ExpectedPayCol
            // 
            this.ExpectedPayCol.Text = "Expected";
            this.ExpectedPayCol.Width = 65;
            // 
            // ActualPayCol
            // 
            this.ActualPayCol.Text = "Actual";
            this.ActualPayCol.Width = 65;
            // 
            // AddPaymentButton
            // 
            this.AddPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPaymentButton.Location = new System.Drawing.Point(49, 279);
            this.AddPaymentButton.Name = "AddPaymentButton";
            this.AddPaymentButton.Size = new System.Drawing.Size(85, 40);
            this.AddPaymentButton.TabIndex = 15;
            this.AddPaymentButton.Text = "Add";
            this.AddPaymentButton.UseVisualStyleBackColor = true;
            this.AddPaymentButton.Click += new System.EventHandler(this.AddPaymentButton_Click);
            // 
            // HoursListViewBox
            // 
            this.HoursListViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateCol2,
            this.Type,
            this.Hours,
            this.Rate});
            this.HoursListViewBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursListViewBox.FullRowSelect = true;
            this.HoursListViewBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.HoursListViewBox.Location = new System.Drawing.Point(730, 77);
            this.HoursListViewBox.Name = "HoursListViewBox";
            this.HoursListViewBox.Size = new System.Drawing.Size(356, 242);
            this.HoursListViewBox.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.HoursListViewBox.TabIndex = 16;
            this.HoursListViewBox.UseCompatibleStateImageBehavior = false;
            this.HoursListViewBox.View = System.Windows.Forms.View.Details;
            this.HoursListViewBox.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.HoursListViewBox_ColumnWidthChanging);
            // 
            // DateCol2
            // 
            this.DateCol2.Text = "Date";
            this.DateCol2.Width = 130;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // Hours
            // 
            this.Hours.Text = "Hours";
            this.Hours.Width = 50;
            // 
            // Rate
            // 
            this.Rate.Text = "Rate";
            this.Rate.Width = 50;
            // 
            // LinkHoursPayButton
            // 
            this.LinkHoursPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinkHoursPayButton.Location = new System.Drawing.Point(637, 149);
            this.LinkHoursPayButton.Name = "LinkHoursPayButton";
            this.LinkHoursPayButton.Size = new System.Drawing.Size(87, 40);
            this.LinkHoursPayButton.TabIndex = 17;
            this.LinkHoursPayButton.Text = "Link";
            this.LinkHoursPayButton.UseVisualStyleBackColor = true;
            this.LinkHoursPayButton.Click += new System.EventHandler(this.LinkHoursPayButton_Click);
            // 
            // UnlinkHoursPayButton
            // 
            this.UnlinkHoursPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnlinkHoursPayButton.Location = new System.Drawing.Point(637, 195);
            this.UnlinkHoursPayButton.Name = "UnlinkHoursPayButton";
            this.UnlinkHoursPayButton.Size = new System.Drawing.Size(87, 40);
            this.UnlinkHoursPayButton.TabIndex = 18;
            this.UnlinkHoursPayButton.Text = "Unlink";
            this.UnlinkHoursPayButton.UseVisualStyleBackColor = true;
            this.UnlinkHoursPayButton.Click += new System.EventHandler(this.UnlinkHoursPayButton_Click);
            // 
            // DeletePaymentButton
            // 
            this.DeletePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePaymentButton.Location = new System.Drawing.Point(140, 279);
            this.DeletePaymentButton.Name = "DeletePaymentButton";
            this.DeletePaymentButton.Size = new System.Drawing.Size(85, 40);
            this.DeletePaymentButton.TabIndex = 19;
            this.DeletePaymentButton.Text = "Delete";
            this.DeletePaymentButton.UseVisualStyleBackColor = true;
            this.DeletePaymentButton.Click += new System.EventHandler(this.DeletePaymentButton_Click);
            // 
            // ActualPayLabel
            // 
            this.ActualPayLabel.AutoSize = true;
            this.ActualPayLabel.Location = new System.Drawing.Point(295, 24);
            this.ActualPayLabel.Name = "ActualPayLabel";
            this.ActualPayLabel.Size = new System.Drawing.Size(89, 30);
            this.ActualPayLabel.TabIndex = 21;
            this.ActualPayLabel.Text = "Actual £";
            // 
            // ActualPayTextBox
            // 
            this.ActualPayTextBox.Location = new System.Drawing.Point(379, 24);
            this.ActualPayTextBox.Name = "ActualPayTextBox";
            this.ActualPayTextBox.Size = new System.Drawing.Size(100, 35);
            this.ActualPayTextBox.TabIndex = 22;
            // 
            // SetActualPayButton
            // 
            this.SetActualPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetActualPayButton.Location = new System.Drawing.Point(485, 24);
            this.SetActualPayButton.Name = "SetActualPayButton";
            this.SetActualPayButton.Size = new System.Drawing.Size(62, 35);
            this.SetActualPayButton.TabIndex = 23;
            this.SetActualPayButton.Text = "Set";
            this.SetActualPayButton.UseVisualStyleBackColor = true;
            this.SetActualPayButton.Click += new System.EventHandler(this.SetActualPayButton_Click);
            // 
            // LogPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 461);
            this.Controls.Add(this.SetActualPayButton);
            this.Controls.Add(this.ActualPayTextBox);
            this.Controls.Add(this.ActualPayLabel);
            this.Controls.Add(this.DeletePaymentButton);
            this.Controls.Add(this.UnlinkHoursPayButton);
            this.Controls.Add(this.LinkHoursPayButton);
            this.Controls.Add(this.HoursListViewBox);
            this.Controls.Add(this.AddPaymentButton);
            this.Controls.Add(this.PayListViewBox);
            this.Controls.Add(this.EmploymentNameLabel);
            this.Controls.Add(this.EmploymentLabel);
            this.Controls.Add(this.SelectedDateLabel);
            this.Controls.Add(this.DateSelectedLabel);
            this.Controls.Add(this.PayDateSelector);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "LogPayForm";
            this.Text = "LogPayForm";
            this.Load += new System.EventHandler(this.LogPayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar PayDateSelector;
        private System.Windows.Forms.Label DateSelectedLabel;
        private System.Windows.Forms.Label SelectedDateLabel;
        private System.Windows.Forms.Label EmploymentLabel;
        private System.Windows.Forms.Label EmploymentNameLabel;
        private System.Windows.Forms.ListView PayListViewBox;
        private System.Windows.Forms.ColumnHeader DateCol1;
        private System.Windows.Forms.ColumnHeader HoursWorkedCol;
        private System.Windows.Forms.ColumnHeader ExpectedPayCol;
        private System.Windows.Forms.ColumnHeader ActualPayCol;
        private System.Windows.Forms.Button AddPaymentButton;
        private System.Windows.Forms.ListView HoursListViewBox;
        private System.Windows.Forms.ColumnHeader DateCol2;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Hours;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.Button LinkHoursPayButton;
        private System.Windows.Forms.Button UnlinkHoursPayButton;
        private System.Windows.Forms.Button DeletePaymentButton;
        private System.Windows.Forms.Label ActualPayLabel;
        private System.Windows.Forms.TextBox ActualPayTextBox;
        private System.Windows.Forms.Button SetActualPayButton;
    }
}