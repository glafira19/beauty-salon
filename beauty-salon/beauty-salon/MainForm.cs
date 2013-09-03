using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            _currentUser = new User("ProstoySmertniy");
            UpdateFormName();
        }

        private void UpdateFormName()
        {
            Text = FORM_NAME + " | вы зашли как: "+_currentUser.GetName();
        }
    }
}
