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
        private List<User> _clients;

        public MainForm()
        {
            InitializeComponent();
            ChangeUser(new User("ProstoySmertniy"));
            LoadServicesAndClients();
            UpdateElementsEnabitity();
        }

        private void LoadServicesAndClients()
        {
            UpdateServicesInformation();
            _clients = XmlWorker.GetClients();
            uiClientsComboBox.DataSource = _clients;
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
            Text = FormName + " | вы зашли как: " + _currentUser.Name;
        }

        private void UpdateElementsEnabitity()
        {
            uiClientPanel.Visible = _currentUser.Role == User.UserRole.Client ||
                                    _currentUser.Role == User.UserRole.Admin || _currentUser.Role == User.UserRole.User;
            uiClientServicesListBox.Visible = _currentUser.Role == User.UserRole.Admin ||
                                              _currentUser.Role == User.UserRole.User;
            uiAdminPanel.Visible = _currentUser.Role == User.UserRole.Admin;

            if (_currentUser.Role == User.UserRole.Client)
            {
                _selectedClient = _currentUser;
                UpdateClientInformation();
            }
            if (_currentUser.Role == User.UserRole.Admin || _currentUser.Role == User.UserRole.User)
            {
                _selectedClient = (User) uiClientsComboBox.SelectedItem;
                UpdateClientInformation();
            }
            SetWindowsWith();
        }

        private void SetWindowsWith()
        {
            switch (_currentUser.Role)
            {
                case User.UserRole.Admin:
                    Width = 800;
                    Height = 500;
                    return;
                case User.UserRole.Client:
                    Width = 800;
                    Height = 500;
                    return;
                case User.UserRole.User:
                    Width = 800;
                    Height = 500;
                    return;
                default:
                    Width = 300;
                    Height = 500;
                    return;
            }
        }


        private void UpdateClientInformation()
        {
            if (_selectedClient == null)
            {
                return;
            }
            var selectedClientServices = XmlWorker.GetServices(_selectedClient.Login);
            _selectedClient.Services = selectedClientServices;
            uiClientServicesListBox.DataSource = _selectedClient.Services;
        }

        private void uiClientAddServiceButton_Click(object sender, EventArgs e)
        {
            AddSelectedClientService();
        }

        private void AddSelectedClientService()
        {
            if (uiServicesListBox.SelectedItem != null)
            {
                var selectedService = uiServicesListBox.SelectedItem;
                _selectedClient.AddService((Service) selectedService, uiServiceDateTimePicker.Value);
                _selectedClient.SaveServices();
                UpdateClientInformation();
            }
        }

        private void uiClientDeleteServiceButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedClientService();
        }

        private void RemoveSelectedClientService()
        {
            if (uiClientServicesListBox.SelectedItem != null)
            {
                _selectedClient.RemoveService((ClientService) uiClientServicesListBox.SelectedItem);
                _selectedClient.SaveServices();
                UpdateElementsEnabitity();
            }
        }

        private void uiClientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateClientInformation();
        }

        private void uAddServicesButton_Click(object sender, EventArgs e)
        {
            AddService();
        }

        private void AddService()
        {
            var serviceForm = new ServiceForm();
            if (serviceForm.ShowDialog() == DialogResult.OK)
            {
                XmlWorker.AddService(serviceForm.CurrentService, false);
                UpdateServicesInformation();
            }
        }

        private void uiEditServicesButton_Click(object sender, EventArgs e)
        {
            EditService();
        }

        private void EditService()
        {
            var serviceForm = new ServiceForm();            
            if (uiServicesListBox.SelectedItem != null)
            {
                serviceForm.CurrentService = (Service) uiServicesListBox.SelectedItem;
                if (serviceForm.ShowDialog() == DialogResult.OK)
                {
                    XmlWorker.AddService(serviceForm.CurrentService, true);
                    UpdateServicesInformation();
                    UpdateClientInformation();
                }
            }
        }
        private void uiRemoveServicesButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedService();
        }

        private void RemoveSelectedService()
        {
            if (uiServicesListBox.SelectedItem != null)
            {
                XmlWorker.RemoveService((Service) uiServicesListBox.SelectedItem);
                UpdateServicesInformation();
                UpdateClientInformation();
            }
        }

        private void UpdateServicesInformation()
        {
            var services = XmlWorker.GetServices();
            uiServicesListBox.DataSource = services;
        }
    }
}
