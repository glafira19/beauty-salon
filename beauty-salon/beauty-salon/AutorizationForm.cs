using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace beauty_salon
{
    public partial class AutorizationForm : Form
    {
        private const string SETTINGS_FILE = ".\\Data\\Settings.Xml";
        public User SelectedUser { get; set; }
        private List<User> AllUser { get; set; }

        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            AllUser = LoadAllUser();
        }

        private List<User> LoadAllUser()
        {
            XDocument xDocument = XDocument.Load(SETTINGS_FILE);
            var list = new List<User>();
            if (xDocument.Root != null)
                foreach (var xElement in xDocument.Root.Elements())
                {
                    if (xElement.Name == "LastLogin")
                    {
                        SetLastLogin(xElement.Value);
                    }
                    if (xElement.Name == "Users")
                    {
                        list.AddRange(from e in xElement.Elements()
                                      where e.Name == "User"
                                      select new User(e));
                    }
                }
            return list;
        }

        private void SetLastLogin(string value)
        {
            uiLoginTextBox.Text = value;
        }

        private void uiLoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (AllUser.Any(u => u.Login == uiLoginTextBox.Text && u.Password == uiPasswordTextBox.Text))
            {
                SelectedUser = AllUser.First(u => u.Login == uiLoginTextBox.Text && u.Password == uiPasswordTextBox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }else
            {
                uiLoginButton.Text = "неверный пользователь или пароль";
            }
        }
    }
}
