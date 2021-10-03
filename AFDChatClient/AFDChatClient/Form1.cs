using System;
using System.Windows.Forms;

namespace AFDChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client.updateChatbox = updateChatbox;
            Client.updateUserlist = updateUserlist;
            Client.fetchUserList();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            Client.sendIM((string)userList.SelectedItem, tSend.Text);
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            Client.fetchUserList();
        }

        // these will be accessed from another thread
        // so i make it thread-safe with delegate workaround

        public void updateUserlist(string users)
        {
            userList.Invoke((MethodInvoker)delegate
            {
                userList.Items.Clear();
                userList.Items.AddRange(users.Split(','));
            });
        }

        public void updateChatbox(string message)
        {
            chatBox.Invoke((MethodInvoker)delegate
            {
                chatBox.AppendText(message);
                chatBox.AppendText(Environment.NewLine);
            });
        }
    
    }
}
