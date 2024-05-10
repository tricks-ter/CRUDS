namespace CRUD
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.update_username = new System.Windows.Forms.TextBox();
            this.update_password = new System.Windows.Forms.TextBox();
            this.user2 = new System.Windows.Forms.TextBox();
            this.btn_update2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Update UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Update Password";
            // 
            // update_username
            // 
            this.update_username.Location = new System.Drawing.Point(319, 113);
            this.update_username.Name = "update_username";
            this.update_username.Size = new System.Drawing.Size(181, 26);
            this.update_username.TabIndex = 3;
            // 
            // update_password
            // 
            this.update_password.Location = new System.Drawing.Point(319, 153);
            this.update_password.Name = "update_password";
            this.update_password.Size = new System.Drawing.Size(181, 26);
            this.update_password.TabIndex = 4;
            // 
            // user2
            // 
            this.user2.Location = new System.Drawing.Point(319, 55);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(181, 26);
            this.user2.TabIndex = 5;
            // 
            // btn_update2
            // 
            this.btn_update2.Location = new System.Drawing.Point(284, 212);
            this.btn_update2.Name = "btn_update2";
            this.btn_update2.Size = new System.Drawing.Size(132, 56);
            this.btn_update2.TabIndex = 6;
            this.btn_update2.Text = "Update";
            this.btn_update2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update2);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.update_password);
            this.Controls.Add(this.update_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox update_username;
        private System.Windows.Forms.TextBox update_password;
        private System.Windows.Forms.TextBox user2;
        private System.Windows.Forms.Button btn_update2;
    }
}