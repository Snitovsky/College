namespace WindowsFormsApplication2
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
            this.NotConfirmed = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConfirmUser = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotConfirmed
            // 
            this.NotConfirmed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.NotConfirmed.GridLines = true;
            this.NotConfirmed.Location = new System.Drawing.Point(12, 12);
            this.NotConfirmed.Name = "NotConfirmed";
            this.NotConfirmed.Size = new System.Drawing.Size(369, 212);
            this.NotConfirmed.TabIndex = 0;
            this.NotConfirmed.UseCompatibleStateImageBehavior = false;
            this.NotConfirmed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Login";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Permitions";
            this.columnHeader3.Width = 78;
            // 
            // ConfirmUser
            // 
            this.ConfirmUser.Location = new System.Drawing.Point(434, 83);
            this.ConfirmUser.Name = "ConfirmUser";
            this.ConfirmUser.Size = new System.Drawing.Size(75, 23);
            this.ConfirmUser.TabIndex = 1;
            this.ConfirmUser.Text = "Confirm";
            this.ConfirmUser.UseVisualStyleBackColor = true;
            this.ConfirmUser.Click += new System.EventHandler(this.ConfirmUser_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(433, 129);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 2;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 466);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.ConfirmUser);
            this.Controls.Add(this.NotConfirmed);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView NotConfirmed;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button ConfirmUser;
        private System.Windows.Forms.Button Del;
    }
}