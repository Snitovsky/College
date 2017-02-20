using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{



    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            label4.Text = null;
            StreamReader read = new StreamReader(@"users.txt", Encoding.Default);
            string[] users = read.ReadToEnd().Split('.');
            string[] Solo=null;
            foreach (string i in users)
            {
                if (!String.IsNullOrEmpty(i))
                {
                    Solo = i.Split(',');
                    User.UserList.Add(new User(Solo[0], Solo[1], Solo[2]));
                }
                Solo = null;
            }
            StreamReader readbase = new StreamReader(@"offerbase.txt", Encoding.Default);
            string[] offers = readbase.ReadToEnd().Split('.');
            foreach (string i in offers)
            {
                if (!String.IsNullOrEmpty(i))
                {
                    Solo = i.Split(',');
                    ListViewItem offer = new ListViewItem(Solo[0]);
                    offer.SubItems.Add(Solo[1]);
                    offer.SubItems.Add(Solo[2]);
                    offer.SubItems.Add(Solo[3]);
                    offer.SubItems.Add(Solo[4]);
                    listView1.Items.Add(offer);
                }
                Solo = null;
            }
            //label4.Text = users[1];
            //label4.Visible = true;

        }
        string property = "no";
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = login.Text.ToString();
            string Pass = pass.Text.ToString();
            foreach (User i in User.UserList)
                if (i.login == Login && i.pass == Pass)
                {
                    property = i.prop;
                    registration.Visible = false;
                    login.Visible = false;
                    pass.Visible = false;
                    Logout.Visible = true;
                    button1.Visible = false;
                }
            if (property == "user")
            {
                buy.Visible = true;         
            }
            if (property == "provider")
            {
                add.Visible = true;
            }
            else if (property == "admin")
            {
                buy.Visible = true;
                add.Visible = true;
                del.Visible = true;
                confirm.Visible = true;

            }
            else if (property == "no")
            {
                login.Visible = true;
                pass.Visible = true;
                pass.Text = "";
                Logout.Visible = false;
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            registration.Visible = true;
            login.Visible = true;
            pass.Visible = true;
            Logout.Visible = false;
            button1.Visible = true;
            buy.Visible = false;
            add.Visible = false;
            del.Visible = false;
            pass.Text = "";
            label4.Text = "";
            //label4.Text = "0";
            label4.Visible = false;
            property = "no";
            confirm.Visible = false;
            //update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Add offer")
            {
                ListViewItem offer = new ListViewItem(name.Text.ToString());
                offer.SubItems.Add(info.Text.ToString());
                offer.SubItems.Add(cost.Text.ToString());
                offer.SubItems.Add(login.Text.ToString());
                offer.SubItems.Add(year.Text.ToString());
                listView1.Items.Add(offer);
                pictureBox.Visible = false;
                name.Visible = false;
                info.Visible = false;
                cost.Visible = false;
                who.Visible = false;
                year.Visible = false;
                button2.Visible = false;
                label5.Visible = label6.Visible = label7.Visible = label8.Visible = label9.Visible = false;
                name.Text = null;
                info.Text = null;
                cost.Text = null;
                //who.Text = null;
                year.Text = null;
            }
            else if(button2.Text=="Registrate")
            {
                StreamWriter write = new StreamWriter(@"notconfirm.txt", true);
                write.Write(name.Text + "," + info.Text + "," + cost.Text + ".");
                write.Close();
                pictureBox.Visible = false;
                name.Visible = false;
                info.Visible = false;
                cost.Visible = false;
                name.Text = null;
                info.Text = null;
                cost.Text = null;
                permit.Visible = false;
                rlog.Visible = false;
                rpass.Visible = false;
                button2.Visible = false;
                MessageBox.Show("Заявка отправлена, ожидайте одобрения администратора!");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            name.Visible = true;
            info.Visible = true;
            cost.Visible = true;
            //who.Visible = true;
            year.Visible = true;
            button2.Text = "Add offer";
            button2.Visible = true;
            label5.Visible = label6.Visible = label7.Visible  = label9.Visible = true;
            //label8.Visible = true;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buy_Click(object sender, EventArgs e)
        {
            label4.Text += listView1.SelectedItems[0].SubItems[0].Text + " " + listView1.SelectedItems[0].SubItems[2].Text +"\n";
            //label4.Text = (Convert.ToInt32(label4.Text) + Convert.ToInt32(listView1.SelectedItems[0].SubItems[2].Text)).ToString();
            //label4.Visible = true;
        }

        private void del_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void info_TextChanged(object sender, EventArgs e)
        {


        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            permit.Visible = true;
            name.Visible = true;
            info.Visible = true;
            rlog.Visible = true;
            rpass.Visible = true;
            cost.Visible = true;
            button2.Text = "Registrate";
            button2.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        public void update()
        {
            StreamWriter addtobase = new StreamWriter(@"offerbase.txt");
            foreach (ListViewItem i in listView1.Items)
            {
                addtobase.Write(i.SubItems[0].Text + "," + i.SubItems[1].Text + "," + i.SubItems[2].Text + "," + i.SubItems[3].Text+ "," + i.SubItems[4].Text +".");
            }
            addtobase.Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            update();
        }
    }

    public class User
    {
        public string login;
        public string pass;
        public string prop;

        public User(string login, string pass, string prop)
        {

            this.login = login;
            this.pass = pass;
            this.prop = prop;
            
        }
        public static List<User> UserList = new List<User>();
        
    }
}
