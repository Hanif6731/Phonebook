using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace WFA.PhoneBook
{
    public delegate void BackDelegate();
    public partial class ContactsForm : MetroForm
    {
        
        internal int Id { set; get; }
        internal string Name { set; get; }
        internal string Email { set; get; }
        public ContactsForm()
        {
            InitializeComponent();
            this.PopulateData();
        }

        private void PopulateData(string sql = "select * from contacts order by name;")
        {
            DataSet Ds = DataAccess.ExecuteQuery(sql);
            this.dgvContacts.AutoGenerateColumns = true;
            this.dgvContacts.DataSource = Ds.Tables[0];
        }

        private void DgbContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Id = Convert.ToInt32(this.dgvContacts.SelectedCells[0].Value.ToString());
            this.Name = this.dgvContacts.SelectedCells[1].Value.ToString();
            this.Email = this.dgvContacts.SelectedCells[2].Value.ToString();
            if (this.Email == "-")
            {
                this.Email = "";
            }
            BackDelegate backDelegate = new BackDelegate(Back);
            new ContactInformationForm(backDelegate,this.Id,this.Name,this.Email).Visible = true;
            this.Visible = false;
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            BackDelegate backDelegate = new BackDelegate(Back);
            new ContactRegistratonForm(backDelegate).Visible = true;
            this.Visible = false;
        }
        private void Back()
        {
            this.Visible = true;
            this.PopulateData();
        }

        private void ContactsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select * from contacts where name like '%"+this.txtAutoSearch.Text+"%' order by name;";
                this.PopulateData(sql);

            }
            catch(Exception ex)
            {
                this.PopulateData();
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
