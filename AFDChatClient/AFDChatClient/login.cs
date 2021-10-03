using System;
using System.Windows.Forms;

namespace AFDChatClient
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (Client.Login(tServer.Text, tNickname.Text))
            {
                var form = new Form1();
                form.Show();
                form.Text = tNickname.Text;
                this.Hide();
            }
            else
                MessageBox.Show("Sorry, Did NOT happen ! :(", "Error");
        }
    }
}
