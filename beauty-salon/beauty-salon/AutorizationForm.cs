﻿using System;
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
            AllUser = LoadAllUser();
        }

        private List<User> LoadAllUser()
        {
            var list = new List<User>();
            var user = new User("Admin");
            user.SetRole(User.Role.Admin);
            list.Add(user);
            return list;
        }

        private void uiLoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (uiLoginTextBox.Text == "admin")
            {
                if (uiLoginTextBox.Text == "admin")
                {
                    SelectedUser = AllUser.First();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
