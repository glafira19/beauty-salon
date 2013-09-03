using System;
using System.Windows.Forms;

namespace beauty_salon
{
    public partial class MainForm : Form
    {
        public const string FORM_NAME = "Салон красоты \"ромашка\"";
        private User _currentUser;

        public MainForm()
        {
            InitializeComponent();
            ChangeUser(new User("ProstoySmertniy"));
        }

        private void UpdateFormName()
        {
            Text = FORM_NAME + " | вы зашли как: "+_currentUser.GetName();
        }

        private void uiAutorizationButton_Click(object sender, EventArgs e)
        {
            Hide();
            var autorizationForm = new AutorizationForm();
            if (autorizationForm.ShowDialog() == DialogResult.OK)
            {
                ChangeUser(autorizationForm.SelectedUser);
            }
            Show();
        }

        private void ChangeUser(User user)
        {
            _currentUser = user;
            UpdateFormName();
        }
    }
}
