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
    public partial class ContactRegistratonForm : MetroForm
    {


        private string[] OldNumbers = new string[2];
        
        private PhoneBook.BackDelegate backDelegate1;
        
        private int Id { set; get; }
        private string FirstName { set; get; }
        private string LastName { set; get; }
        private string Email { set; get; }
        private string[] phone = new string[2];
        

        
        public ContactRegistratonForm(PhoneBook.BackDelegate backDelegate1)
        {
            InitializeComponent();
            this.backDelegate1 = backDelegate1;
            this.Id = DataAccess.ID+1;
            
            
            
        }
        public ContactRegistratonForm(int id, string name, string email,List<string> phoneNumers, PhoneBook.BackDelegate backDelegate1)
        {
            InitializeComponent();
            this.pnlAddMorePhone.Visible = true;
            this.backDelegate1 = backDelegate1;
            this.Id = id;
            string[] Names = name.Split(' ');
            this.FirstName= this.txtFirstName.Text = Names[0];
            for (int i = 1; i < Names.Length; i++)
            {
                if (i == 1)
                {
                    this.LastName = Names[i];
                }
                else
                {
                    this.LastName +=" "+ Names[i];
                }
            }
            this.txtLastName.Text = this.LastName;
            this.Email = this.txtEmail.Text = email;
            phone[0] = phoneNumers.ElementAt(0);
            if (phoneNumers.Count == 2)
                phone[1] = phoneNumers.ElementAt(1);
            this.phone.CopyTo(this.OldNumbers, 0);
            int totalNumbers = phoneNumers.Count;
            this.txtPhone1.Text = this.phone[0];
            if (totalNumbers == 2)
            {
                this.txtPhone2.Text = this.phone[1];
                this.pnlAddPhone.Visible = true;
            }
            
            



        }


        private void BtnAddPhone_Click(object sender, EventArgs e)
        {
            this.pnlAddPhone.Visible = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string sql;
            
            this.FirstName = this.txtFirstName.Text;
            this.LastName = this.txtLastName.Text;
            this.Email = this.txtEmail.Text;
            this.phone[0] = this.txtPhone1.Text;
            this.phone[1] = this.txtPhone2.Text;
            if (PhoneBook.ValidateText.Text(this.Email)==false)
            {
                this.Email = "-";
            }
            else
            {
                if (PhoneBook.ValidateText.ValidEmail(this.Email))
                {
                    
                }
                else
                {
                    MessageBox.Show("Email is not Valid!");
                    return;
                }

            }
            if (PhoneBook.ValidateText.Text(this.FirstName+this.LastName,this.txtPhone1.Text))
            {
                if (this.Validation())
                {
                    if (this.Id > DataAccess.SearchMaxID())
                    {
                        try
                        {
                            sql = @"insert into contacts values(" + this.Id + ",'" + this.FirstName + " " + this.LastName + "','" + this.Email + "');";
                            DataAccess.ExecuteUpdateQuery(sql);
                            sql = @"insert into id_phone values(" + this.Id + ",'" + this.phone[0] + "');";
                            DataAccess.ExecuteUpdateQuery(sql);
                            if (ValidateText.Text(this.txtPhone2.Text))
                            {
                                sql = @"insert into id_phone values(" + this.Id + ",'" + this.phone[1] + "');";
                                DataAccess.ExecuteUpdateQuery(sql);

                            }
                            DataAccess.ID++;
                            MessageBox.Show("Contact Saved!", "Saved!");
                            this.back();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        try
                        {
                            sql = @"update contacts set name='" + this.FirstName + " " + this.LastName + "',email='" + this.Email + "'where id=" + this.Id + ";";
                            DataAccess.ExecuteUpdateQuery(sql);
                            sql = @"update id_phone set phone='" + this.phone[0] + "' where id = " + this.Id + " and phone='" + this.OldNumbers[0] + "';";
                            DataAccess.ExecuteUpdateQuery(sql);
                            if (ValidateText.Text(this.txtPhone2.Text))
                            {
                                if (this.OldNumbers[1] == null)
                                {
                                    sql = @"insert into id_phone values(" + this.Id + ",'" + this.phone[1] + "');";
                                    DataAccess.ExecuteUpdateQuery(sql);
                                }
                                else
                                {

                                    sql = @"update id_phone set phone='" + this.phone[1] + "' where id = " + this.Id + " and phone='" + this.OldNumbers[1] + "';";
                                    DataAccess.ExecuteUpdateQuery(sql);

                                }

                            }
                            DataAccess.ID++;
                            MessageBox.Show("Contact Updated!", "Updated!");
                            this.back();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You might have missed the name or phone box.\nWould you mind, checking the name or phone box, please?\nYou have to insert your name and at least one phone number.", "Warning!!");
            }

            
            
            
        }

        private void back()
        {
            backDelegate1();
            this.Dispose();
        }

        private void ContactRegistratonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.back();
        }

        private bool Validation()
        {
            
            bool flag = false;
            try
            {
                if (ValidateText.Text(this.txtPhone1.Text))
                {
                    if (ValidateText.IsNumber(this.txtPhone1.Text))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Number Cannot contain alphabets", "Warning!!!");
                    }

                }
                if (ValidateText.Text(this.txtPhone2.Text))
                {
                    if (ValidateText.IsNumber(this.txtPhone2.Text))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        MessageBox.Show("Number Cannot contain alphabets", "Warning!!!");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return flag;
        }

        private void BtnAddMorePhone_Click(object sender, EventArgs e)
        {
            new AddNumberForm(this.Id).Visible = true;
        }
    }
}
