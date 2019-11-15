using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using labManagement.Data;

namespace labManagement.Repository
    {
    class LoginRepository
        {
        FormLogin Login;

        private DataAccess Da
            {
            get;
            set;
            }
        private DataSet Ds
            {
            get;
            set;
            }
        public LoginRepository(FormLogin Login)
            {

            this.Login = Login;
            this.Da = new DataAccess();
            
            }

        public void SignIn()
            {
            string sql = "select * from AdminTable where AdminName = '" + this.Login.textBoxUsername.Text + "' and AdminPassword='" + this.Login.textBoxPassword.Text + "' ";


            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count > 0)
                {
                this.Login.Hide();
                AdminPanel ad = new AdminPanel(Login);
                ad.Show();
                }
            else
                {

                this.StudentSignin();

                }
            }
        private void StudentSignin()
            {
            string sql = "select * from UserTable where UserName = '" + this.Login.textBoxUsername.Text + "' and Password='" + this.Login.textBoxPassword.Text + "' ";
            try
                {
                this.Ds = this.Da.ExecuteQuery(sql);
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.ToString());
                }
            if (this.Ds != null && this.Ds.Tables.Count > 0 && this.Ds.Tables[0].Rows.Count > 0)
                {
                this.Login.Hide();
                UserPanel up = new UserPanel(Login, this.Login.textBoxUsername.Text);
                up.Show();

                }
            else
                {
                MessageBox.Show("Check Username and Password");
                }
            }
        }
    }
