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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StreamReader read = new StreamReader(@"notconfirm.txt", Encoding.Default);
            string[] users = read.ReadToEnd().Split('.');
            string[] Solo = null;
            foreach (string i in users)
            {
                if (!String.IsNullOrEmpty(i))
                {
                    Solo = i.Split(',');
                    ListViewItem person = new ListViewItem(Solo[0]);
                    person.SubItems.Add(Solo[1]);
                    person.SubItems.Add(Solo[2]);
                    NotConfirmed.Items.Add(person);
                    User.UserList.Add(new User(Solo[0], Solo[1], Solo[2]));
                }
                Solo = null;
            }

            //ListViewItem offer = new ListViewItem(name.Text.ToString());

        }

        private void ConfirmUser_Click(object sender, EventArgs e)
        {
            StreamWriter addtobase = new StreamWriter(@"users.txt", true);
            addtobase.Write(NotConfirmed.SelectedItems[0].SubItems[0].Text + "," + NotConfirmed.SelectedItems[0].SubItems[1].Text + "," + NotConfirmed.SelectedItems[0].SubItems[2].Text + ".");
            addtobase.Close();
            NotConfirmed.SelectedItems[0].Remove();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            NotConfirmed.SelectedItems[0].Remove();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //protected void Form2_Closing(object sender, CancelEventArgs e)
       // {
        
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter addtobase = new StreamWriter(@"notconfirm.txt");
            foreach (ListViewItem i in NotConfirmed.Items)
            {
                addtobase.Write(i.SubItems[0].Text + "," + i.SubItems[1].Text + "," + i.SubItems[2].Text + ".");
            }
            addtobase.Close();
        }
    }
}
