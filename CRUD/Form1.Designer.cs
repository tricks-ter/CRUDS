namespace CRUD
{
    partial class Form1
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
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.search_user = new System.Windows.Forms.TextBox();
            this.delete_user = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(149, 39);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(201, 26);
            this.user.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(150, 83);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(201, 26);
            this.pass.TabIndex = 3;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(198, 143);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(92, 34);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(293, 228);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 35);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(293, 291);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 31);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // search_user
            // 
            this.search_user.Location = new System.Drawing.Point(78, 232);
            this.search_user.Name = "search_user";
            this.search_user.Size = new System.Drawing.Size(157, 26);
            this.search_user.TabIndex = 8;
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(78, 296);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(157, 26);
            this.delete_user.TabIndex = 10;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(349, 133);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(103, 55);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.delete_user);
            this.Controls.Add(this.search_user);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox search_user;
        private System.Windows.Forms.TextBox delete_user;
        private System.Windows.Forms.Button btn_update;
    }
}

