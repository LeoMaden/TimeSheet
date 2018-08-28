namespace FormUI
{
    partial class LogHoursForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CalendarBox = new System.Windows.Forms.MonthCalendar();
            this.DateSelectedLabel = new System.Windows.Forms.Label();
            this.SelectedDateLabel = new System.Windows.Forms.Label();
            this.HoursTypeLabel = new System.Windows.Forms.Label();
            this.HoursTypeComboBox = new System.Windows.Forms.ComboBox();
            this.NumberHoursLabel = new System.Windows.Forms.Label();
            this.HoursWorkedEntryBox = new System.Windows.Forms.TextBox();
            this.EmploymentLabel = new System.Windows.Forms.Label();
            this.EmploymentNameLabel = new System.Windows.Forms.Label();
            this.HourlyRateLabel = new System.Windows.Forms.Label();
            this.HourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.SubmitHoursButton = new System.Windows.Forms.Button();
            this.HoursListViewBox = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteSelectedHoursButton = new System.Windows.Forms.Button();
            this.HoursViewOptionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(167, 45);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Log Hours";
            // 
            // CalendarBox
            // 
            this.CalendarBox.Location = new System.Drawing.Point(25, 63);
            this.CalendarBox.MaxSelectionCount = 1;
            this.CalendarBox.Name = "CalendarBox";
            this.CalendarBox.ShowWeekNumbers = true;
            this.CalendarBox.TabIndex = 1;
            this.CalendarBox.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarBox_DateChanged);
            // 
            // DateSelectedLabel
            // 
            this.DateSelectedLabel.AutoSize = true;
            this.DateSelectedLabel.Location = new System.Drawing.Point(20, 238);
            this.DateSelectedLabel.Name = "DateSelectedLabel";
            this.DateSelectedLabel.Size = new System.Drawing.Size(146, 30);
            this.DateSelectedLabel.TabIndex = 2;
            this.DateSelectedLabel.Text = "Date Selected:";
            // 
            // SelectedDateLabel
            // 
            this.SelectedDateLabel.AutoSize = true;
            this.SelectedDateLabel.Location = new System.Drawing.Point(172, 238);
            this.SelectedDateLabel.Name = "SelectedDateLabel";
            this.SelectedDateLabel.Size = new System.Drawing.Size(125, 30);
            this.SelectedDateLabel.TabIndex = 3;
            this.SelectedDateLabel.Text = "XX/XX/XXXX";
            // 
            // HoursTypeLabel
            // 
            this.HoursTypeLabel.AutoSize = true;
            this.HoursTypeLabel.Location = new System.Drawing.Point(20, 291);
            this.HoursTypeLabel.Name = "HoursTypeLabel";
            this.HoursTypeLabel.Size = new System.Drawing.Size(61, 30);
            this.HoursTypeLabel.TabIndex = 4;
            this.HoursTypeLabel.Text = "Type:";
            // 
            // HoursTypeComboBox
            // 
            this.HoursTypeComboBox.FormattingEnabled = true;
            this.HoursTypeComboBox.Location = new System.Drawing.Point(87, 288);
            this.HoursTypeComboBox.Name = "HoursTypeComboBox";
            this.HoursTypeComboBox.Size = new System.Drawing.Size(178, 38);
            this.HoursTypeComboBox.TabIndex = 5;
            // 
            // NumberHoursLabel
            // 
            this.NumberHoursLabel.AutoSize = true;
            this.NumberHoursLabel.Location = new System.Drawing.Point(20, 355);
            this.NumberHoursLabel.Name = "NumberHoursLabel";
            this.NumberHoursLabel.Size = new System.Drawing.Size(73, 30);
            this.NumberHoursLabel.TabIndex = 6;
            this.NumberHoursLabel.Text = "Hours:";
            // 
            // HoursWorkedEntryBox
            // 
            this.HoursWorkedEntryBox.Location = new System.Drawing.Point(120, 352);
            this.HoursWorkedEntryBox.Name = "HoursWorkedEntryBox";
            this.HoursWorkedEntryBox.Size = new System.Drawing.Size(100, 35);
            this.HoursWorkedEntryBox.TabIndex = 7;
            // 
            // EmploymentLabel
            // 
            this.EmploymentLabel.AutoSize = true;
            this.EmploymentLabel.Location = new System.Drawing.Point(342, 40);
            this.EmploymentLabel.Name = "EmploymentLabel";
            this.EmploymentLabel.Size = new System.Drawing.Size(134, 30);
            this.EmploymentLabel.TabIndex = 8;
            this.EmploymentLabel.Text = "Employment:";
            // 
            // EmploymentNameLabel
            // 
            this.EmploymentNameLabel.AutoSize = true;
            this.EmploymentNameLabel.Location = new System.Drawing.Point(482, 40);
            this.EmploymentNameLabel.Name = "EmploymentNameLabel";
            this.EmploymentNameLabel.Size = new System.Drawing.Size(157, 30);
            this.EmploymentNameLabel.TabIndex = 9;
            this.EmploymentNameLabel.Text = "<employment>";
            // 
            // HourlyRateLabel
            // 
            this.HourlyRateLabel.AutoSize = true;
            this.HourlyRateLabel.Location = new System.Drawing.Point(342, 84);
            this.HourlyRateLabel.Name = "HourlyRateLabel";
            this.HourlyRateLabel.Size = new System.Drawing.Size(127, 30);
            this.HourlyRateLabel.TabIndex = 10;
            this.HourlyRateLabel.Text = "Hourly Rate:";
            // 
            // HourlyRateTextBox
            // 
            this.HourlyRateTextBox.Location = new System.Drawing.Point(475, 81);
            this.HourlyRateTextBox.Name = "HourlyRateTextBox";
            this.HourlyRateTextBox.Size = new System.Drawing.Size(100, 35);
            this.HourlyRateTextBox.TabIndex = 11;
            // 
            // SubmitHoursButton
            // 
            this.SubmitHoursButton.BackColor = System.Drawing.Color.Transparent;
            this.SubmitHoursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitHoursButton.Location = new System.Drawing.Point(91, 407);
            this.SubmitHoursButton.Name = "SubmitHoursButton";
            this.SubmitHoursButton.Size = new System.Drawing.Size(104, 43);
            this.SubmitHoursButton.TabIndex = 12;
            this.SubmitHoursButton.Text = "Submit";
            this.SubmitHoursButton.UseVisualStyleBackColor = false;
            this.SubmitHoursButton.Click += new System.EventHandler(this.SubmitHoursButton_Click);
            // 
            // HoursListViewBox
            // 
            this.HoursListViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Type,
            this.Hours,
            this.Rate});
            this.HoursListViewBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursListViewBox.FullRowSelect = true;
            this.HoursListViewBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.HoursListViewBox.Location = new System.Drawing.Point(303, 145);
            this.HoursListViewBox.Name = "HoursListViewBox";
            this.HoursListViewBox.Size = new System.Drawing.Size(356, 242);
            this.HoursListViewBox.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.HoursListViewBox.TabIndex = 13;
            this.HoursListViewBox.UseCompatibleStateImageBehavior = false;
            this.HoursListViewBox.View = System.Windows.Forms.View.Details;
            this.HoursListViewBox.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.HoursListViewBox_ColumnWidthChanging);
            this.HoursListViewBox.SelectedIndexChanged += new System.EventHandler(this.HoursListViewBox_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 130;
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
            // DeleteSelectedHoursButton
            // 
            this.DeleteSelectedHoursButton.BackColor = System.Drawing.Color.DarkGray;
            this.DeleteSelectedHoursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedHoursButton.Location = new System.Drawing.Point(555, 393);
            this.DeleteSelectedHoursButton.Name = "DeleteSelectedHoursButton";
            this.DeleteSelectedHoursButton.Size = new System.Drawing.Size(104, 43);
            this.DeleteSelectedHoursButton.TabIndex = 14;
            this.DeleteSelectedHoursButton.Text = "Delete";
            this.DeleteSelectedHoursButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedHoursButton.Click += new System.EventHandler(this.DeleteSelectedHoursButton_Click);
            // 
            // HoursViewOptionComboBox
            // 
            this.HoursViewOptionComboBox.FormattingEnabled = true;
            this.HoursViewOptionComboBox.Location = new System.Drawing.Point(303, 393);
            this.HoursViewOptionComboBox.Name = "HoursViewOptionComboBox";
            this.HoursViewOptionComboBox.Size = new System.Drawing.Size(188, 38);
            this.HoursViewOptionComboBox.TabIndex = 15;
            this.HoursViewOptionComboBox.SelectedIndexChanged += new System.EventHandler(this.HoursViewOptionComboBox_SelectedIndexChanged);
            // 
            // LogHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 470);
            this.Controls.Add(this.HoursViewOptionComboBox);
            this.Controls.Add(this.DeleteSelectedHoursButton);
            this.Controls.Add(this.HoursListViewBox);
            this.Controls.Add(this.SubmitHoursButton);
            this.Controls.Add(this.HourlyRateTextBox);
            this.Controls.Add(this.HourlyRateLabel);
            this.Controls.Add(this.EmploymentNameLabel);
            this.Controls.Add(this.EmploymentLabel);
            this.Controls.Add(this.HoursWorkedEntryBox);
            this.Controls.Add(this.NumberHoursLabel);
            this.Controls.Add(this.HoursTypeComboBox);
            this.Controls.Add(this.HoursTypeLabel);
            this.Controls.Add(this.SelectedDateLabel);
            this.Controls.Add(this.DateSelectedLabel);
            this.Controls.Add(this.CalendarBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LogHoursForm";
            this.Text = "Log Hours";
            this.Load += new System.EventHandler(this.LogHoursForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.MonthCalendar CalendarBox;
        private System.Windows.Forms.Label DateSelectedLabel;
        private System.Windows.Forms.Label SelectedDateLabel;
        private System.Windows.Forms.Label HoursTypeLabel;
        private System.Windows.Forms.ComboBox HoursTypeComboBox;
        private System.Windows.Forms.Label NumberHoursLabel;
        private System.Windows.Forms.TextBox HoursWorkedEntryBox;
        private System.Windows.Forms.Label EmploymentLabel;
        private System.Windows.Forms.Label EmploymentNameLabel;
        private System.Windows.Forms.Label HourlyRateLabel;
        private System.Windows.Forms.TextBox HourlyRateTextBox;
        private System.Windows.Forms.Button SubmitHoursButton;
        private System.Windows.Forms.ListView HoursListViewBox;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Hours;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.Button DeleteSelectedHoursButton;
        private System.Windows.Forms.ComboBox HoursViewOptionComboBox;
    }
}

