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
    public partial class AddNumberForm : MetroForm
    {
        private int Id { set; get; }
        private string Phone { set; get; }
        private ContactInformationForm CI { set; get; }
        public AddNumberForm(int id)
        {
            InitializeComponent();
            this.Id = id;

        }
        public AddNumberForm( int id, string phone,ContactInformationForm ci)
        {
            InitializeComponent();
            this.Id = id;
            this.Phone = phone;
            this.txtPhone.Text = this.Phone;
            this.CI = ci;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateText.Text(this.txtPhone.Text))
            {
                if (ValidateText.IsNumber(this.txtPhone.Text))
                {
                    string sql;
                    if (this.Phone == null)
                    {
                        sql = "insert into id_phone values (" + this.Id + ", '" + this.txtPhone.Text + "');";

                    }
                    else
                    {
                        sql = "update id_phone set phone='" + this.txtPhone.Text + "' where id=" + this.Id + " and phone = '" + this.Phone + "';";
                    }
                    try
                    {
                        DataAccess.ExecuteUpdateQuery(sql);
                        MessageBox.Show("Saved!!");
                        if (this.Phone != null)
                        {
                            sql = @"select * from id_phone where id=" + this.Id + ";";
                            this.CI.PopulateData(sql);
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Not a valid Phone no");
                }
            }
        }
    }
}
