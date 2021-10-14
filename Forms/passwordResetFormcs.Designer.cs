
namespace ClientRecord.Forms
{
    partial class passwordResetFormcs
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.resetDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.securityQuestionLable = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.resetPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.resetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.loginButton);
            this.panel5.Controls.Add(this.exitButton);
            this.panel5.Controls.Add(this.searchButton);
            this.panel5.Controls.Add(this.submitButton);
            this.panel5.Controls.Add(this.resetPanel);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.securityQuestionLable);
            this.panel5.Controls.Add(this.answerTextBox);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.resetDatePicker);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.emailTextBox);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Location = new System.Drawing.Point(2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(869, 650);
            this.panel5.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(339, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(211, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Please Reset Your password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(119, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Enter Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(255, 108);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(480, 26);
            this.emailTextBox.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Enter Date Of Birth:";
            // 
            // resetDatePicker
            // 
            this.resetDatePicker.CustomFormat = "";
            this.resetDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.resetDatePicker.Location = new System.Drawing.Point(255, 219);
            this.resetDatePicker.Name = "resetDatePicker";
            this.resetDatePicker.Size = new System.Drawing.Size(480, 26);
            this.resetDatePicker.TabIndex = 4;
            this.resetDatePicker.Value = new System.DateTime(2021, 10, 13, 21, 26, 28, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(198, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Answer Security Question:";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(255, 308);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(480, 26);
            this.answerTextBox.TabIndex = 6;
            // 
            // securityQuestionLable
            // 
            this.securityQuestionLable.AutoSize = true;
            this.securityQuestionLable.Location = new System.Drawing.Point(255, 271);
            this.securityQuestionLable.Name = "securityQuestionLable";
            this.securityQuestionLable.Size = new System.Drawing.Size(0, 20);
            this.securityQuestionLable.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Security Question:";
            // 
            // resetPanel
            // 
            this.resetPanel.Controls.Add(this.resetButton);
            this.resetPanel.Controls.Add(this.label21);
            this.resetPanel.Controls.Add(this.confirmPassTextBox);
            this.resetPanel.Controls.Add(this.passtextBox);
            this.resetPanel.Controls.Add(this.label20);
            this.resetPanel.Location = new System.Drawing.Point(164, 390);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(571, 145);
            this.resetPanel.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(163, 20);
            this.label20.TabIndex = 12;
            this.label20.Text = "Enter New Password:";
            // 
            // passtextBox
            // 
            this.passtextBox.Location = new System.Drawing.Point(200, 9);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(258, 26);
            this.passtextBox.TabIndex = 13;
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Location = new System.Drawing.Point(200, 50);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Size = new System.Drawing.Size(258, 26);
            this.confirmPassTextBox.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(183, 20);
            this.label21.TabIndex = 14;
            this.label21.Text = "Confirm New Password:";
            // 
            // resetButton
            // 
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Location = new System.Drawing.Point(294, 91);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(164, 36);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset Password";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Location = new System.Drawing.Point(571, 345);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(164, 36);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(571, 157);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(164, 36);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(765, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 37);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(545, 601);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(190, 37);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Go to Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordResetFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(871, 653);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(204)))), ((int)(((byte)(95)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "passwordResetFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "passwordResetFormcs";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.resetPanel.ResumeLayout(false);
            this.resetPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel resetPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox confirmPassTextBox;
        private System.Windows.Forms.TextBox passtextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label securityQuestionLable;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker resetDatePicker;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
    }
}