namespace FormUI
{
    partial class SelectEmploymentForm
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
            this.EmploymentOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.AddNewEmploymentButton = new System.Windows.Forms.Button();
            this.SelectEmploymentHoursButton = new System.Windows.Forms.Button();
            this.EditEmploymentButton = new System.Windows.Forms.Button();
            this.SelectEmploymentPayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Employment";
            // 
            // EmploymentOptionsComboBox
            // 
            this.EmploymentOptionsComboBox.FormattingEnabled = true;
            this.EmploymentOptionsComboBox.Location = new System.Drawing.Point(21, 77);
            this.EmploymentOptionsComboBox.Name = "EmploymentOptionsComboBox";
            this.EmploymentOptionsComboBox.Size = new System.Drawing.Size(282, 38);
            this.EmploymentOptionsComboBox.TabIndex = 1;
            // 
            // AddNewEmploymentButton
            // 
            this.AddNewEmploymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewEmploymentButton.Location = new System.Drawing.Point(309, 77);
            this.AddNewEmploymentButton.Name = "AddNewEmploymentButton";
            this.AddNewEmploymentButton.Size = new System.Drawing.Size(39, 38);
            this.AddNewEmploymentButton.TabIndex = 2;
            this.AddNewEmploymentButton.Text = "+";
            this.AddNewEmploymentButton.UseVisualStyleBackColor = false;
            this.AddNewEmploymentButton.Click += new System.EventHandler(this.AddNewEmploymentButton_Click);
            // 
            // SelectEmploymentHoursButton
            // 
            this.SelectEmploymentHoursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectEmploymentHoursButton.Location = new System.Drawing.Point(21, 121);
            this.SelectEmploymentHoursButton.Name = "SelectEmploymentHoursButton";
            this.SelectEmploymentHoursButton.Size = new System.Drawing.Size(85, 41);
            this.SelectEmploymentHoursButton.TabIndex = 3;
            this.SelectEmploymentHoursButton.Text = "Hours";
            this.SelectEmploymentHoursButton.UseVisualStyleBackColor = true;
            this.SelectEmploymentHoursButton.Click += new System.EventHandler(this.ChooseSelectedEmploymentButton_Click);
            // 
            // EditEmploymentButton
            // 
            this.EditEmploymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEmploymentButton.Location = new System.Drawing.Point(273, 121);
            this.EditEmploymentButton.Name = "EditEmploymentButton";
            this.EditEmploymentButton.Size = new System.Drawing.Size(75, 41);
            this.EditEmploymentButton.TabIndex = 4;
            this.EditEmploymentButton.Text = "Edit";
            this.EditEmploymentButton.UseVisualStyleBackColor = true;
            this.EditEmploymentButton.Click += new System.EventHandler(this.EditEmploymentButton_Click);
            // 
            // SelectEmploymentPayButton
            // 
            this.SelectEmploymentPayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectEmploymentPayButton.Location = new System.Drawing.Point(112, 121);
            this.SelectEmploymentPayButton.Name = "SelectEmploymentPayButton";
            this.SelectEmploymentPayButton.Size = new System.Drawing.Size(85, 41);
            this.SelectEmploymentPayButton.TabIndex = 5;
            this.SelectEmploymentPayButton.Text = "Pay";
            this.SelectEmploymentPayButton.UseVisualStyleBackColor = true;
            this.SelectEmploymentPayButton.Click += new System.EventHandler(this.SelectEmploymentPayButton_Click);
            // 
            // SelectEmploymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 198);
            this.Controls.Add(this.SelectEmploymentPayButton);
            this.Controls.Add(this.EditEmploymentButton);
            this.Controls.Add(this.SelectEmploymentHoursButton);
            this.Controls.Add(this.AddNewEmploymentButton);
            this.Controls.Add(this.EmploymentOptionsComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SelectEmploymentForm";
            this.Text = "Select Employment";
            this.Load += new System.EventHandler(this.SelectEmploymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EmploymentOptionsComboBox;
        private System.Windows.Forms.Button AddNewEmploymentButton;
        private System.Windows.Forms.Button SelectEmploymentHoursButton;
        private System.Windows.Forms.Button EditEmploymentButton;
        private System.Windows.Forms.Button SelectEmploymentPayButton;
    }
}