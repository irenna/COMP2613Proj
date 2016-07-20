namespace COMP2614Assign06
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.panelInputClientData = new System.Windows.Forms.Panel();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.textBoxClientCode = new System.Windows.Forms.TextBox();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.textBoxYtdSales = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.labelYtdSales = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.panelViewClientData = new System.Windows.Forms.Panel();
            this.labelClientData = new System.Windows.Forms.Label();
            this.labelClientLegend = new System.Windows.Forms.Label();
            this.panelInputClientData.SuspendLayout();
            this.panelViewClientData.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 20;
            this.listBoxClients.Location = new System.Drawing.Point(12, 12);
            this.listBoxClients.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(260, 764);
            this.listBoxClients.TabIndex = 2;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // panelInputClientData
            // 
            this.panelInputClientData.Controls.Add(this.buttonDeleteClient);
            this.panelInputClientData.Controls.Add(this.buttonNewClient);
            this.panelInputClientData.Controls.Add(this.textBoxClientCode);
            this.panelInputClientData.Controls.Add(this.labelClientCode);
            this.panelInputClientData.Controls.Add(this.buttonSave);
            this.panelInputClientData.Controls.Add(this.textBoxNotes);
            this.panelInputClientData.Controls.Add(this.textBoxYtdSales);
            this.panelInputClientData.Controls.Add(this.textBoxPostalCode);
            this.panelInputClientData.Controls.Add(this.textBoxProvince);
            this.panelInputClientData.Controls.Add(this.textBoxCity);
            this.panelInputClientData.Controls.Add(this.textBoxAddress2);
            this.panelInputClientData.Controls.Add(this.textBoxAddress1);
            this.panelInputClientData.Controls.Add(this.textBoxCompanyName);
            this.panelInputClientData.Controls.Add(this.labelNotes);
            this.panelInputClientData.Controls.Add(this.checkBoxCreditHold);
            this.panelInputClientData.Controls.Add(this.labelYtdSales);
            this.panelInputClientData.Controls.Add(this.labelPostalCode);
            this.panelInputClientData.Controls.Add(this.labelProvince);
            this.panelInputClientData.Controls.Add(this.labelCity);
            this.panelInputClientData.Controls.Add(this.labelAddress2);
            this.panelInputClientData.Controls.Add(this.labelAddress1);
            this.panelInputClientData.Controls.Add(this.labelCompanyName);
            this.panelInputClientData.Location = new System.Drawing.Point(280, 12);
            this.panelInputClientData.Name = "panelInputClientData";
            this.panelInputClientData.Size = new System.Drawing.Size(604, 489);
            this.panelInputClientData.TabIndex = 0;
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(231, 439);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(136, 31);
            this.buttonDeleteClient.TabIndex = 21;
            this.buttonDeleteClient.Text = "Delete";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(50, 439);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(136, 31);
            this.buttonNewClient.TabIndex = 20;
            this.buttonNewClient.Text = "New Client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // textBoxClientCode
            // 
            this.textBoxClientCode.Location = new System.Drawing.Point(231, 31);
            this.textBoxClientCode.Name = "textBoxClientCode";
            this.textBoxClientCode.Size = new System.Drawing.Size(100, 26);
            this.textBoxClientCode.TabIndex = 1;
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Location = new System.Drawing.Point(46, 34);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(95, 20);
            this.labelClientCode.TabIndex = 0;
            this.labelClientCode.Text = "Client Code:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(408, 439);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 31);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(231, 343);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(313, 26);
            this.textBoxNotes.TabIndex = 17;
            // 
            // textBoxYtdSales
            // 
            this.textBoxYtdSales.Location = new System.Drawing.Point(231, 304);
            this.textBoxYtdSales.Name = "textBoxYtdSales";
            this.textBoxYtdSales.Size = new System.Drawing.Size(100, 26);
            this.textBoxYtdSales.TabIndex = 15;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(231, 265);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 26);
            this.textBoxPostalCode.TabIndex = 13;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(231, 226);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(200, 26);
            this.textBoxProvince.TabIndex = 11;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(231, 187);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(313, 26);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(231, 148);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(313, 26);
            this.textBoxAddress2.TabIndex = 7;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(231, 109);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(313, 26);
            this.textBoxAddress1.TabIndex = 5;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(231, 70);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(313, 26);
            this.textBoxCompanyName.TabIndex = 3;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(46, 346);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(55, 20);
            this.labelNotes.TabIndex = 16;
            this.labelNotes.Text = "Notes:";
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(50, 387);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(114, 24);
            this.checkBoxCreditHold.TabIndex = 18;
            this.checkBoxCreditHold.Text = "Credit Hold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // labelYtdSales
            // 
            this.labelYtdSales.AutoSize = true;
            this.labelYtdSales.Location = new System.Drawing.Point(46, 307);
            this.labelYtdSales.Name = "labelYtdSales";
            this.labelYtdSales.Size = new System.Drawing.Size(152, 20);
            this.labelYtdSales.TabIndex = 14;
            this.labelYtdSales.Text = "Year to Date Sales: ";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(46, 268);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(99, 20);
            this.labelPostalCode.TabIndex = 12;
            this.labelPostalCode.Text = "Postal Code:";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(46, 229);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(73, 20);
            this.labelProvince.TabIndex = 10;
            this.labelProvince.Text = "Province:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(46, 190);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(39, 20);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = "City:";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(46, 151);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(85, 20);
            this.labelAddress2.TabIndex = 6;
            this.labelAddress2.Text = "Address 2:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(46, 112);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(72, 20);
            this.labelAddress1.TabIndex = 4;
            this.labelAddress1.Text = "Address:";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(46, 73);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(126, 20);
            this.labelCompanyName.TabIndex = 2;
            this.labelCompanyName.Text = "Company Name:";
            // 
            // panelViewClientData
            // 
            this.panelViewClientData.Controls.Add(this.labelClientData);
            this.panelViewClientData.Controls.Add(this.labelClientLegend);
            this.panelViewClientData.Location = new System.Drawing.Point(280, 507);
            this.panelViewClientData.Name = "panelViewClientData";
            this.panelViewClientData.Size = new System.Drawing.Size(604, 264);
            this.panelViewClientData.TabIndex = 1;
            // 
            // labelClientData
            // 
            this.labelClientData.Location = new System.Drawing.Point(280, 33);
            this.labelClientData.Name = "labelClientData";
            this.labelClientData.Size = new System.Drawing.Size(292, 224);
            this.labelClientData.TabIndex = 1;
            this.labelClientData.Text = "a\r\nb\r\nc\r\nd\r\ne\r\nf\r\ng\r\nh\r\ni";
            // 
            // labelClientLegend
            // 
            this.labelClientLegend.Location = new System.Drawing.Point(42, 33);
            this.labelClientLegend.Name = "labelClientLegend";
            this.labelClientLegend.Size = new System.Drawing.Size(160, 224);
            this.labelClientLegend.TabIndex = 0;
            this.labelClientLegend.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 789);
            this.Controls.Add(this.panelViewClientData);
            this.Controls.Add(this.panelInputClientData);
            this.Controls.Add(this.listBoxClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelInputClientData.ResumeLayout(false);
            this.panelInputClientData.PerformLayout();
            this.panelViewClientData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Panel panelInputClientData;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxYtdSales;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.Label labelYtdSales;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Panel panelViewClientData;
        private System.Windows.Forms.Label labelClientData;
        private System.Windows.Forms.Label labelClientLegend;
        private System.Windows.Forms.Label labelClientCode;
        private System.Windows.Forms.TextBox textBoxClientCode;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonNewClient;
    }
}

