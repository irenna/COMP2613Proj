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
    /// <summary>
    /// Main class for form
    /// </summary>
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

        /// <summary>
        /// Main Form constructor
        /// </summary>
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
                //I think it makes sense to leave these as message boxes.  In theory, they shouldn't even happen.
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
            textBoxYtdSales.DataBindings.Add("Text", clientVM, "YtdSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
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
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = clientVM.GetDisplayClient();
                List<string> errorList;
                if (!textBoxClientCode.ReadOnly)
                {
                    //New Client
                    errorList = ClientValidation.AddClient(client);
                }
                else
                {
                    //Existing Client
                    errorList = ClientValidation.UpdateClient(client);
                }

                if (errorList.Count == 0)
                {
                    clientVM.Clients = ClientRepository.GetClients();
                    listBoxClients.DataSource = clientVM.Clients;
                    listBoxClients.DisplayMember = "ClientCode";
                    errorProvider.SetError(buttonSave, string.Empty);
                }
                else if (errorList.Count > 0)
                {
                    StringBuilder errorText = new StringBuilder();
                    errorText.Append("Error:\r\n");
                    foreach (string error in errorList)
                    {
                        errorText.Append(error + "\r\n");
                    }
                    errorProvider.SetError(buttonSave, errorText.ToString());
                }
            }
            catch (SqlException ex)
            {
                //I think it makes sense to leave these as message boxes.  In theory, they shouldn't even happen.
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            errorProvider.SetError(buttonSave, string.Empty);
            clientVM.SetDisplayClient(new Client());
            textBoxClientCode.ReadOnly = false;
            textBoxClientCode.Select();
            textBoxClientCode.SelectAll();
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            
            errorProvider.SetError(buttonSave, string.Empty);

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
