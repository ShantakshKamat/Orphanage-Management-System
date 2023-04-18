
namespace ShantakshProject
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.orphan = new System.Windows.Forms.Button();
            this.donor = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orphan
            // 
            this.orphan.BackColor = System.Drawing.Color.Purple;
            this.orphan.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orphan.ForeColor = System.Drawing.Color.White;
            this.orphan.Location = new System.Drawing.Point(12, 32);
            this.orphan.Name = "orphan";
            this.orphan.Size = new System.Drawing.Size(112, 90);
            this.orphan.TabIndex = 0;
            this.orphan.Text = "  View and Edit Orphan Details";
            this.orphan.UseVisualStyleBackColor = false;
            this.orphan.Click += new System.EventHandler(this.button1_Click);
            // 
            // donor
            // 
            this.donor.BackColor = System.Drawing.Color.Purple;
            this.donor.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donor.ForeColor = System.Drawing.Color.White;
            this.donor.Location = new System.Drawing.Point(12, 158);
            this.donor.Name = "donor";
            this.donor.Size = new System.Drawing.Size(112, 88);
            this.donor.TabIndex = 1;
            this.donor.Text = "View and Edit Donation Records";
            this.donor.UseVisualStyleBackColor = false;
            this.donor.Click += new System.EventHandler(this.button2_Click);
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.Purple;
            this.employee.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.Color.White;
            this.employee.Location = new System.Drawing.Point(12, 281);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(112, 87);
            this.employee.TabIndex = 2;
            this.employee.Text = "View and Edit Employee Details";
            this.employee.UseVisualStyleBackColor = false;
            this.employee.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(163, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Life is too short.Smile while you still have teeth!";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(775, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.donor);
            this.Controls.Add(this.orphan);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orphan;
        private System.Windows.Forms.Button donor;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Label label1;
    }
}