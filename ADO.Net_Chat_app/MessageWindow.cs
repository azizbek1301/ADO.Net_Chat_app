using ADO.Net_Chat_app.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.Net_Chat_app
{
    public partial class Message_Window : Form
    {
        public string UserName { get; set; }
        public Message_Window(string userName)
        {
            UserName = userName;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.MessageInsert(textBox1.Text, userName: UserName);
            textBox1.Text = "";
            MessageBox.Show("Xabar jo'natildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var res = Database.GetMessages();
            foreach (var item in res)
            {

                richTextBox1.Text = item;

            }


        }
    }
}
