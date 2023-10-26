using ADO.Net_Chat_app.Services;

namespace ADO.Net_Chat_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                Message_Window msgWin = new Message_Window(textBox1.Text);
                msgWin.Show();
                this.Hide();
                Database.Insert(textBox1.Text, textBox2.Text);

            
                  


        }
    }
}