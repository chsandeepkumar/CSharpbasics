namespace WindowsAppGridView
{
    partial class EmployeeDetailsForm
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
            this.employeedataGridView = new System.Windows.Forms.DataGridView();
            this.employeeDetailLabel = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeedataGridView
            // 
            this.employeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeedataGridView.Location = new System.Drawing.Point(12, 90);
            this.employeedataGridView.Name = "employeedataGridView";
            this.employeedataGridView.RowTemplate.Height = 28;
            this.employeedataGridView.Size = new System.Drawing.Size(810, 314);
            this.employeedataGridView.TabIndex = 0;
            // 
            // employeeDetailLabel
            // 
            this.employeeDetailLabel.AutoSize = true;
            this.employeeDetailLabel.Location = new System.Drawing.Point(84, 34);
            this.employeeDetailLabel.Name = "employeeDetailLabel";
            this.employeeDetailLabel.Size = new System.Drawing.Size(132, 20);
            this.employeeDetailLabel.TabIndex = 1;
            this.employeeDetailLabel.Text = "Employee Details";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(318, 30);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(117, 33);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "View Data";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(987, 416);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.employeeDetailLabel);
            this.Controls.Add(this.employeedataGridView);
            this.Name = "EmployeeDetailsForm";
            this.Text = "Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.employeedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeedataGridView;
        private System.Windows.Forms.Label employeeDetailLabel;
        private System.Windows.Forms.Button buttonView;
    }
}

