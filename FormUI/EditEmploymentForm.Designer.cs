namespace FormUI
{
    partial class EditEmploymentForm
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
            this.EditEmploymentTitleLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.HourlyRateLabel = new System.Windows.Forms.Label();
            this.EmploymentEndedCheckBox = new System.Windows.Forms.CheckBox();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CompanyNameEntryBox = new System.Windows.Forms.TextBox();
            this.HourlyRateEntryBox = new System.Windows.Forms.TextBox();
            this.SaveEmploymentButton = new System.Windows.Forms.Button();
            this.DeleteEmploymentButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.WeekBeginsLabel = new System.Windows.Forms.Label();
            this.WeekBeginsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EditEmploymentTitleLabel
            // 
            this.EditEmploymentTitleLabel.AutoSize = true;
            this.EditEmploymentTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmploymentTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.EditEmploymentTitleLabel.Name = "EditEmploymentTitleLabel";
            this.EditEmploymentTitleLabel.Size = new System.Drawing.Size(262, 45);
            this.EditEmploymentTitleLabel.TabIndex = 0;
            this.EditEmploymentTitleLabel.Text = "Edit Employment";
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(21, 75);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(168, 30);
            this.CompanyNameLabel.TabIndex = 1;
            this.CompanyNameLabel.Text = "Company Name:";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(21, 115);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(110, 30);
            this.StartDateLabel.TabIndex = 2;
            this.StartDateLabel.Text = "Start Date:";
            // 
            // HourlyRateLabel
            // 
            this.HourlyRateLabel.AutoSize = true;
            this.HourlyRateLabel.Location = new System.Drawing.Point(21, 155);
            this.HourlyRateLabel.Name = "HourlyRateLabel";
            this.HourlyRateLabel.Size = new System.Drawing.Size(127, 30);
            this.HourlyRateLabel.TabIndex = 3;
            this.HourlyRateLabel.Text = "Hourly Rate:";
            // 
            // EmploymentEndedCheckBox
            // 
            this.EmploymentEndedCheckBox.AutoSize = true;
            this.EmploymentEndedCheckBox.Location = new System.Drawing.Point(26, 234);
            this.EmploymentEndedCheckBox.Name = "EmploymentEndedCheckBox";
            this.EmploymentEndedCheckBox.Size = new System.Drawing.Size(99, 34);
            this.EmploymentEndedCheckBox.TabIndex = 4;
            this.EmploymentEndedCheckBox.Text = "Ended?";
            this.EmploymentEndedCheckBox.UseVisualStyleBackColor = true;
            this.EmploymentEndedCheckBox.CheckedChanged += new System.EventHandler(this.EmploymentEndedCheckBox_CheckedChanged);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(45, 271);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(103, 30);
            this.EndDateLabel.TabIndex = 5;
            this.EndDateLabel.Text = "End Date:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(154, 267);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 35);
            this.EndDatePicker.TabIndex = 6;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Location = new System.Drawing.Point(137, 111);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 35);
            this.StartDatePicker.TabIndex = 7;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // CompanyNameEntryBox
            // 
            this.CompanyNameEntryBox.Location = new System.Drawing.Point(195, 75);
            this.CompanyNameEntryBox.Name = "CompanyNameEntryBox";
            this.CompanyNameEntryBox.Size = new System.Drawing.Size(176, 35);
            this.CompanyNameEntryBox.TabIndex = 8;
            this.CompanyNameEntryBox.TextChanged += new System.EventHandler(this.CompanyNameEntryBox_TextChanged);
            // 
            // HourlyRateEntryBox
            // 
            this.HourlyRateEntryBox.Location = new System.Drawing.Point(154, 152);
            this.HourlyRateEntryBox.Name = "HourlyRateEntryBox";
            this.HourlyRateEntryBox.Size = new System.Drawing.Size(176, 35);
            this.HourlyRateEntryBox.TabIndex = 9;
            this.HourlyRateEntryBox.TextChanged += new System.EventHandler(this.HourlyRateEntryBox_TextChanged);
            // 
            // SaveEmploymentButton
            // 
            this.SaveEmploymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEmploymentButton.Location = new System.Drawing.Point(26, 312);
            this.SaveEmploymentButton.Name = "SaveEmploymentButton";
            this.SaveEmploymentButton.Size = new System.Drawing.Size(85, 37);
            this.SaveEmploymentButton.TabIndex = 10;
            this.SaveEmploymentButton.Text = "Save";
            this.SaveEmploymentButton.UseVisualStyleBackColor = true;
            this.SaveEmploymentButton.Click += new System.EventHandler(this.SaveEmploymentButton_Click);
            // 
            // DeleteEmploymentButton
            // 
            this.DeleteEmploymentButton.BackColor = System.Drawing.Color.Red;
            this.DeleteEmploymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmploymentButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteEmploymentButton.Location = new System.Drawing.Point(137, 312);
            this.DeleteEmploymentButton.Name = "DeleteEmploymentButton";
            this.DeleteEmploymentButton.Size = new System.Drawing.Size(85, 37);
            this.DeleteEmploymentButton.TabIndex = 11;
            this.DeleteEmploymentButton.Text = "Delete";
            this.DeleteEmploymentButton.UseVisualStyleBackColor = false;
            this.DeleteEmploymentButton.Click += new System.EventHandler(this.DeleteEmploymentButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Green;
            this.StatusLabel.Location = new System.Drawing.Point(246, 315);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 30);
            this.StatusLabel.TabIndex = 12;
            // 
            // WeekBeginsLabel
            // 
            this.WeekBeginsLabel.AutoSize = true;
            this.WeekBeginsLabel.Location = new System.Drawing.Point(21, 193);
            this.WeekBeginsLabel.Name = "WeekBeginsLabel";
            this.WeekBeginsLabel.Size = new System.Drawing.Size(142, 30);
            this.WeekBeginsLabel.TabIndex = 13;
            this.WeekBeginsLabel.Text = "Week begins: ";
            // 
            // WeekBeginsComboBox
            // 
            this.WeekBeginsComboBox.FormattingEnabled = true;
            this.WeekBeginsComboBox.Location = new System.Drawing.Point(154, 190);
            this.WeekBeginsComboBox.Name = "WeekBeginsComboBox";
            this.WeekBeginsComboBox.Size = new System.Drawing.Size(176, 38);
            this.WeekBeginsComboBox.TabIndex = 14;
            this.WeekBeginsComboBox.SelectedIndexChanged += new System.EventHandler(this.WeekBeginsComboBox_SelectedIndexChanged);
            // 
            // EditEmploymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 385);
            this.Controls.Add(this.WeekBeginsComboBox);
            this.Controls.Add(this.WeekBeginsLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DeleteEmploymentButton);
            this.Controls.Add(this.SaveEmploymentButton);
            this.Controls.Add(this.HourlyRateEntryBox);
            this.Controls.Add(this.CompanyNameEntryBox);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.EmploymentEndedCheckBox);
            this.Controls.Add(this.HourlyRateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.EditEmploymentTitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EditEmploymentForm";
            this.Text = "Edit Employment";
            this.Load += new System.EventHandler(this.EditEmploymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditEmploymentTitleLabel;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label HourlyRateLabel;
        private System.Windows.Forms.CheckBox EmploymentEndedCheckBox;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.TextBox CompanyNameEntryBox;
        private System.Windows.Forms.TextBox HourlyRateEntryBox;
        private System.Windows.Forms.Button SaveEmploymentButton;
        private System.Windows.Forms.Button DeleteEmploymentButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label WeekBeginsLabel;
        private System.Windows.Forms.ComboBox WeekBeginsComboBox;
    }
}