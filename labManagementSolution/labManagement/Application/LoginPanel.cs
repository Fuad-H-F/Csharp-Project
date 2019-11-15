using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labManagement.Data;
using labManagement.Repository;

namespace labManagement
    {
    public partial class FormLogin : Form
        {
        LoginRepository log;
        
        private DataSet Ds
            {
            get;
            set;
            }
        public FormLogin()
            {
            InitializeComponent();
            
            this.log = new LoginRepository(this);
            }


        private void buttonSignIn_Click(object sender, EventArgs e)
            {
            this.log.SignIn();
            //string sql = "select * from AdminTable where AdminName = '"+this.textBoxUsername.Text+"' and AdminPassword='"+this.textBoxPassword.Text+"' ";

        
            //    this.Ds = this.Da.ExecuteQuery(sql);
            
            //if (this.Ds.Tables[0].Rows.Count>0)
            //    {
            //    this.Hide();
            //    AdminPanel ad = new AdminPanel(this);
            //    ad.Show();
            //    }
            //else
            //    {

            //    this.StudentSignin();
               
            //    }
            this.textBoxUsername.Text = "";
            this.textBoxPassword.Text = "";
            
           
            }
        //private void StudentSignin()
        //    {
        //    string sql = "select * from UserTable where UserName = '" + this.textBoxUsername.Text + "' and Password='" + this.textBoxPassword.Text + "' ";
        //    try
        //        {
        //        this.Ds = this.Da.ExecuteQuery(sql);
        //        }
        //    catch (Exception ex)
        //        {
        //        MessageBox.Show(ex.ToString());
        //        }
        //    if (this.Ds != null && this.Ds.Tables.Count > 0 && this.Ds.Tables[0].Rows.Count > 0)
        //        {
        //        this.Hide();
        //        UserPanel up = new UserPanel(this, this.textBoxUsername.Text);
        //        up.Show();
               
        //        }
        //    else
        //        {
        //        MessageBox.Show("Check Username and Password");
        //        }
        //    }

        private void buttonExit_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void textBoxUsername_Click(object sender, EventArgs e)
            {
            if (this.textBoxUsername.Text=="Username")
                {
                this.textBoxUsername.Text = "";                
                }
            if (this.textBoxPassword.Text == "")
                {
                this.textBoxPassword.PasswordChar ='\0';
                this.textBoxPassword.Text = "Password";
                }
            }

        private void textBoxPassword_Click(object sender, EventArgs e)
            {
            if (this.textBoxUsername.Text == "")
                {
                this.textBoxUsername.Text = "Username";
                }
            if (this.textBoxPassword.Text=="Password")
                {
                this.textBoxPassword.Text = "";
                this.textBoxPassword.PasswordChar = '*';
                }   
            }
        }
    }
