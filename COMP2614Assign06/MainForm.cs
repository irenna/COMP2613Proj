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
using DataLayer.Validation;

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
            textBoxClientCode.DataBindings.Add("Text", clientVM, "ClientCode");
            textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName");
            textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1");
            textBoxAddress2.DataBindings.Add("Text", clientVM, "Address2");
            textBoxProvince.DataBindings.Add("Text", clientVM, "Province");
            textBoxCity.DataBindings.Add("Text", clientVM, "City");
            textBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode");
            textBoxNotes.DataBindings.Add("Text", clientVM, "Notes");
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
            textBoxClientCode.ReadOnly = true;
            labelClientLegend.Text = string.Empty;
            labelClientData.Text = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = clientVM.GetDisplayClient();
                int rowsAffected;
                if (!textBoxClientCode.ReadOnly)
                {
                    //New Client
                    rowsAffected = ClientValidation.AddClient(client);
                }
                else
                {
                    //Existing Client
                    rowsAffected = ClientValidation.UpdateClient(client);
                }

                if (rowsAffected > 0)
                {
                    clientVM.Clients = ClientRepository.GetClients();
                    listBoxClients.DataSource = clientVM.Clients;
                    listBoxClients.DisplayMember = "ClientCode";
                } 
                else if (rowsAffected == 0)
                {
                    MessageBox.Show("Error creating or updating client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            clientVM.SetDisplayClient(new Client());
            textBoxClientCode.ReadOnly = false;
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
