using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace beauty_salon
{
    public partial class AutorizationForm : Form
    {
        public User SelectedUser { get; set; }
        private List<User> AllUser { get; set; }

        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            AllUser = XmlWorker.GetUsers();
            uiPasswordTextBox.Text = XmlWorker.GetLastLogin();
        }

        private void uiLoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (AllUser.Any(u => u.Login == uiPasswordTextBox.Text && u.Password == uiLoginTextBox.Text))
            {
                SelectedUser = AllUser.First(u => u.Login == uiPasswordTextBox.Text && u.Password == uiLoginTextBox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Text = "неверный пользователь или пароль";
            }
        }
    }
}
