using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.DataAccess;
using DataLayer.Common;

namespace COMP2614Assign06
{
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                clientVM = new ClientViewModel(ClientRepository.GetClients());
                setBindings();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setBindings()
        {
            //TODO need to see what the comparisons are for the "DataSourceUpdateMode.OnValidation"
            textBoxClientCode.DataBindings.Add("Text", clientVM, "ClientCode");
            textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName");
            textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1");
            textBoxAddress2.DataBindings.Add("Text", clientVM, "Address2");
            textBoxProvince.DataBindings.Add("Text", clientVM, "Province");
            textBoxCity.DataBindings.Add("Text", clientVM, "City");
            textBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode");
            textBoxYtdSales.DataBindings.Add("Text", clientVM, "YtdSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00));0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "CreditHold");

            listBoxClients.DataSource = clientVM.Clients;
            listBoxClients.DisplayMember = "ClientCode";
        }

        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxClients.SelectedIndex);
            Client client = clientVM.Clients[selectedIndex];
            clientVM.SetDisplayClient(client);
            labelClientLegend.Text = string.Empty;
            labelClientData.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            clientVM.SetDisplayClient(new Client());
            textBoxClientCode.Select();
            textBoxClientCode.SelectAll();
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client product = clientVM.GetDisplayClient();
                ClientRepository.DeleteClient(product);
                clientVM.Clients = ClientRepository.GetClients();
                listBoxClients.DataSource = clientVM.Clients;
                listBoxClients.DisplayMember = "ClientCode";
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
