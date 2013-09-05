using System;
using System.Windows.Forms;

namespace beauty_salon
{
    public partial class ServiceForm : Form
    {
        public Service CurrentService { get; set; }

        public ServiceForm()
        {
            InitializeComponent();
        }

        private void uiConfirmButton_Click(object sender, EventArgs e)
        {
            if (CurrentService == null)
            {
                CurrentService = new Service();
            }
            CurrentService.Name = uiNameTextBox.Text;
            CurrentService.Cost = Convert.ToDecimal(uiCostTextBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            if (CurrentService != null)
            {
                uiNameTextBox.Text = CurrentService.Name;
                uiCostTextBox.Text = CurrentService.Cost.ToString();
            }
        }
    }
}
