using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace WFA.PhoneBook
{
    public partial class ContactInformationForm : MetroForm
    {
        private int Id { set; get; }
        private string Name { set; get; }
        private string Email { set; get; }
        private string sql { set; get; }
        private PhoneBook.BackDelegate backDelegate1;
        private DataSet Ds { set; get; }
        public ContactInformationForm(PhoneBook.BackDelegate backDelegate1,int id,string name, string email)
        {
            InitializeComponent();
            this.backDelegate1 = backDelegate1;
            this.Id = id;
            this.lblOutputName.Text = this.Name = name;
            this.lbloutputEmail.Text = this.Email = email;
            sql = @"select * from id_phone where id=" + this.Id + ";";
            this.PopulateData(sql);
        }
        public void PopulateData(string sql)
        {
            this.Ds = DataAccess.ExecuteQuery(sql);
            this.dgvPhone.AutoGenerateColumns = true;
            this.dgvPhone.DataSource = Ds.Tables[0];
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            List<string> phoneNumbers = new List<string>();
            foreach(DataGridViewRow phoneRow in this.dgvPhone.Rows)
            {
                phoneNumbers.Add(phoneRow.Cells["phone"].Value.ToString());
            }
            new ContactRegistratonForm(this.Id, this.Name, this.Email, phoneNumbers,this.backDelegate1).Visible = true;
            this.Dispose();

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Back();
        }

        private void ContactInformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                sql = @"delete from contacts where id = "+this.Id+";";
                DataAccess.ExecuteUpdateQuery(sql);
                sql = @"delete from id_phone where id = " + this.Id + ";";
                DataAccess.ExecuteUpdateQuery(sql);
                MessageBox.Show("Contact Deleted", "Deleted!!");
                this.Back();
            }
            catch
            {

            }
        }
        private void Back()
        {
            this.backDelegate1();
            this.Dispose();
        }

        private void DgvPhone_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Delegates.PopulateDataGridView populateDataGridView = this.PopulateData;
            string phone = this.dgvPhone.CurrentRow.Cells[1].Value.ToString();
            new AddNumberForm(this.Id, phone,this).Visible = true;
        }
    }
}
