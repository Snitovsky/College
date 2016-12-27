namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.login = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buy = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.registration = new System.Windows.Forms.Button();
            this.rlog = new System.Windows.Forms.Label();
            this.rpass = new System.Windows.Forms.Label();
            this.permit = new System.Windows.Forms.Label();
            this.who = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(27, 161);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(596, 396);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Название";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Описание услуги";
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Цена";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Представитель";
            this.columnHeader7.Width = 143;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Срок выполнения";
            this.columnHeader1.Width = 126;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(557, 38);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 0;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(557, 82);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 1;
            this.pass.UseSystemPasswordChar = true;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(568, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buy
            // 
            this.buy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buy.Location = new System.Drawing.Point(649, 258);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(75, 23);
            this.buy.TabIndex = 4;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Visible = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Location = new System.Drawing.Point(649, 312);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del.Location = new System.Drawing.Point(649, 365);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 6;
            this.del.TabStop = false;
            this.del.Text = "Remove";
            this.del.UseVisualStyleBackColor = true;
            this.del.Visible = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Location = new System.Drawing.Point(663, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 7;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Visible = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(250, 230);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(303, 316);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(374, 258);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 9;
            this.name.Visible = false;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(374, 291);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(100, 20);
            this.info.TabIndex = 10;
            this.info.Visible = false;
            this.info.TextChanged += new System.EventHandler(this.info_TextChanged);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(374, 333);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(100, 20);
            this.cost.TabIndex = 11;
            this.cost.Visible = false;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(374, 408);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 13;
            this.year.Visible = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(385, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add offer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(958, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Your price:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(96, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "0";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Название";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Описание";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Стоимость";
            this.label7.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Срок выполнения";
            this.label9.Visible = false;
            // 
            // registration
            // 
            this.registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registration.Location = new System.Drawing.Point(663, 119);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(75, 23);
            this.registration.TabIndex = 24;
            this.registration.Text = "Registration";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.button3_Click);
            // 
            // rlog
            // 
            this.rlog.AutoSize = true;
            this.rlog.Location = new System.Drawing.Point(273, 263);
            this.rlog.Name = "rlog";
            this.rlog.Size = new System.Drawing.Size(32, 13);
            this.rlog.TabIndex = 25;
            this.rlog.Text = "login:";
            this.rlog.Visible = false;
            this.rlog.Click += new System.EventHandler(this.label10_Click);
            // 
            // rpass
            // 
            this.rpass.AutoSize = true;
            this.rpass.Location = new System.Drawing.Point(273, 298);
            this.rpass.Name = "rpass";
            this.rpass.Size = new System.Drawing.Size(55, 13);
            this.rpass.TabIndex = 26;
            this.rpass.Text = "password:";
            this.rpass.Visible = false;
            // 
            // permit
            // 
            this.permit.AutoSize = true;
            this.permit.Location = new System.Drawing.Point(273, 336);
            this.permit.Name = "permit";
            this.permit.Size = new System.Drawing.Size(58, 13);
            this.permit.TabIndex = 27;
            this.permit.Text = "Permitions:";
            this.permit.Visible = false;
            // 
            // who
            // 
            this.who.Location = new System.Drawing.Point(374, 368);
            this.who.Name = "who";
            this.who.Size = new System.Drawing.Size(100, 20);
            this.who.TabIndex = 12;
            this.who.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Представитель";
            this.label8.Visible = false;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(277, 11);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 28;
            this.confirm.Text = "Users";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Visible = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.permit);
            this.Controls.Add(this.rpass);
            this.Controls.Add(this.rlog);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.year);
            this.Controls.Add(this.who);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.info);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Label rlog;
        private System.Windows.Forms.Label rpass;
        private System.Windows.Forms.Label permit;
        private System.Windows.Forms.TextBox who;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button confirm;
    }
}

