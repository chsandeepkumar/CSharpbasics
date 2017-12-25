namespace WindowsFormsRegularExpressions
{
    partial class RegularExpressionForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.emailIdTextBox = new System.Windows.Forms.TextBox();
            this.emailIdLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.phonNumberLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(61, 76);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(98, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name : ";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(197, 70);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(299, 26);
            this.firstNameTextbox.TabIndex = 1;
            // 
            // emailIdTextBox
            // 
            this.emailIdTextBox.Location = new System.Drawing.Point(197, 144);
            this.emailIdTextBox.Name = "emailIdTextBox";
            this.emailIdTextBox.Size = new System.Drawing.Size(299, 26);
            this.emailIdTextBox.TabIndex = 3;
            // 
            // emailIdLabel
            // 
            this.emailIdLabel.AutoSize = true;
            this.emailIdLabel.Location = new System.Drawing.Point(61, 150);
            this.emailIdLabel.Name = "emailIdLabel";
            this.emailIdLabel.Size = new System.Drawing.Size(67, 20);
            this.emailIdLabel.TabIndex = 2;
            this.emailIdLabel.Text = "Email-Id";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(197, 211);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(299, 26);
            this.zipCodeTextBox.TabIndex = 5;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(61, 217);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(70, 20);
            this.zipCodeLabel.TabIndex = 4;
            this.zipCodeLabel.Text = "Zip code";
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Location = new System.Drawing.Point(197, 274);
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(299, 26);
            this.phoneNumberTextbox.TabIndex = 7;
            // 
            // phonNumberLabel
            // 
            this.phonNumberLabel.AutoSize = true;
            this.phonNumberLabel.Location = new System.Drawing.Point(61, 280);
            this.phonNumberLabel.Name = "phonNumberLabel";
            this.phonNumberLabel.Size = new System.Drawing.Size(115, 20);
            this.phonNumberLabel.TabIndex = 6;
            this.phonNumberLabel.Text = "Phone Number";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(197, 342);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(111, 35);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(344, 342);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 35);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // regularExpressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 412);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.phoneNumberTextbox);
            this.Controls.Add(this.phonNumberLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.emailIdTextBox);
            this.Controls.Add(this.emailIdLabel);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "regularExpressionForm";
            this.Text = "Regular Expressions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox emailIdTextBox;
        private System.Windows.Forms.Label emailIdLabel;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox phoneNumberTextbox;
        private System.Windows.Forms.Label phonNumberLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

