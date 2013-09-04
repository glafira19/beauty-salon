using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace beauty_salon
{
    public partial class MainForm : Form
    {
        public const string FormName = "Салон красоты \"ромашка\"";
        private User _currentUser;
        private User _selectedClient;
        private List<Service> _services;

        public MainForm()
        {
            InitializeComponent();
            ChangeUser(new User("ProstoySmertniy"));
            LoadServices();
            UpdateElementsEnabitity();
        }

        private void LoadServices()
        {
            _services = XmlWorker.GetServices();
            uiServicesListBox.DataSource = _services;
            uiClientServicesListBox.DataSource = _services;
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
            UpdateElementsEnabitity();
        }

        private void UpdateFormName()
        {
            Text = FormName + " | вы зашли как: "+_currentUser.Name;
        }

        private void UpdateElementsEnabitity()
        {
            uiClientPanel.Visible = _currentUser.Role == User.UserRole.Client;
            if (_currentUser.Role == User.UserRole.Client)
            {
                _selectedClient = _currentUser;
                var selectedClientServices = XmlWorker.GetServices(_selectedClient.Login);
                _selectedClient.Services = selectedClientServices;
                uiClientServicesListBox.DataSource = _selectedClient.Services;
            }
        }

        private void uiClientAddServiceButton_Click(object sender, EventArgs e)
        {
            var selectedService = uiServicesListBox.SelectedItem;
            _selectedClient.AddService((Service)selectedService, uiServiceDateTimePicker.Value);
            _selectedClient.SaveServices();
            UpdateElementsEnabitity();
        }

        private void uiClientDeleteServiceButton_Click(object sender, EventArgs e)
        {
            if (uiClientServicesListBox.SelectedItem != null)
            {
                _selectedClient.RemoveService((ClientService)uiClientServicesListBox.SelectedItem);
                _selectedClient.SaveServices();
                UpdateElementsEnabitity();
            }
        }
    }
}
