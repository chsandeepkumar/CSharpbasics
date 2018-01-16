namespace WindowsAppGridView
{
    partial class EmployeeManagerForm
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
            this.textBoxPersonId = new System.Windows.Forms.TextBox();
            this.labelPersonId = new System.Windows.Forms.Label();
            this.labeltilte = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPersonId
            // 
            this.textBoxPersonId.Location = new System.Drawing.Point(277, 21);
            this.textBoxPersonId.Name = "textBoxPersonId";
            this.textBoxPersonId.Size = new System.Drawing.Size(351, 26);
            this.textBoxPersonId.TabIndex = 0;
            // 
            // labelPersonId
            // 
            this.labelPersonId.AutoSize = true;
            this.labelPersonId.Location = new System.Drawing.Point(124, 27);
            this.labelPersonId.Name = "labelPersonId";
            this.labelPersonId.Size = new System.Drawing.Size(77, 20);
            this.labelPersonId.TabIndex = 1;
            this.labelPersonId.Text = "Person Id";
            // 
            // labeltilte
            // 
            this.labeltilte.AutoSize = true;
            this.labeltilte.Location = new System.Drawing.Point(124, 83);
            this.labeltilte.Name = "labeltilte";
            this.labeltilte.Size = new System.Drawing.Size(38, 20);
            this.labeltilte.TabIndex = 3;
            this.labeltilte.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(277, 77);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(351, 26);
            this.textBoxTitle.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(277, 135);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(149, 32);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(462, 135);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(149, 32);
            this.buttonView.TabIndex = 5;
            this.buttonView.Text = "View Details";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // EmployeeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 461);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labeltilte);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelPersonId);
            this.Controls.Add(this.textBoxPersonId);
            this.Name = "EmployeeManagerForm";
            this.Text = "Employee Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPersonId;
        private System.Windows.Forms.Label labelPersonId;
        private System.Windows.Forms.Label labeltilte;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonView;
    }
}