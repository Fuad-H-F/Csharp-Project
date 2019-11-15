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
    class AdminRepository
        {
        AdminPanel Admin;
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
        public AdminRepository(AdminPanel Admin)
            {
     
            this.Admin = Admin;
            this.Da = new DataAccess();
            
            }
        public DataSet PopulateGridView(string sql = "select * from UserTable")
            {
            this.Ds = this.Da.ExecuteQuery(sql);

            return this.Ds;
            }

        public DataSet SearchUser()
            {
            string sql = "select * from UserTable where StudentId like '" + Admin.textBoxSearchUser.Text + "%' or FirstName like '" + Admin.textBoxSearchUser.Text + "%';";
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
            }



        public void AdminRegister()
            {
            string randPassword = this.RandomPass();
            string sql = @"insert into UserTable 
            values ('" + Admin.textBoxFirstName.Text + "','" + Admin.textBoxLastName.Text + "','" + Admin.comboBoxDepartment.Text + "','" + Admin.textBoxCourse.Text + "','" + Admin.textBoxSection.Text + "','" + Admin.textBoxId.Text + "','" + Admin.textBoxUserName.Text + "','" + randPassword + "','" + Admin.dateTimePickerBirthDate.Text + "','" + Admin.textBoxEmail.Text + "','" + Admin.textBoxAddress.Text + "');";
            try
                {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Registration Done.");
     
                Admin.DisplayAllUser();
                }
            catch (Exception exc)
                {
                MessageBox.Show("Error: " + exc.Message);
                }


            string t = "";
            sql = @"insert into StudentGrade
            values ('" + Admin.textBoxFirstName.Text + "','" + Admin.textBoxId.Text + "','" + Admin.textBoxCourse.Text + "','" + Admin.textBoxSection.Text + "','" + t + "');";
            try
                {
                this.Da.ExecuteUpdateQuery(sql);

                Admin.DisplayAllUser();
                }
            catch (Exception exc)
                {
                MessageBox.Show("Error: " + exc.Message);
                }
            }
        private string RandomPass()
            {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');
            int num = rnd.Next(100, 999);
            string pass = randomChar + num.ToString();
            return pass;
            }

        public void UpdateSearchUser()
            {
            string sid = Admin.textBoxSearch_id.Text;
            string sql = "select * from UserTable where StudentID = '" + sid + "';";

            this.Ds = this.Da.ExecuteQuery(sql);

            Admin.textBoxUPFirstName.Text = this.Ds.Tables[0].Rows[0]["FirstName"].ToString();
            Admin.textBoxUPLastName.Text = this.Ds.Tables[0].Rows[0]["LastName"].ToString();
            Admin.comboBoxUPDepartment.Text = this.Ds.Tables[0].Rows[0]["Department"].ToString();
            Admin.textBoxUPCourse.Text = this.Ds.Tables[0].Rows[0]["Course"].ToString();
            Admin.textBoxUPSection.Text = this.Ds.Tables[0].Rows[0]["Section"].ToString();
            Admin.textBoxUPStudentId.Text = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();
            Admin.textBoxUPUserName.Text = this.Ds.Tables[0].Rows[0]["UserName"].ToString();
            Admin.dateTimePickerUPBirthDate.Text = this.Ds.Tables[0].Rows[0]["DateOfBirth"].ToString();
            Admin.textBoxUPEmail.Text = this.Ds.Tables[0].Rows[0]["Email"].ToString();
            Admin.textBoxUPAddress.Text = this.Ds.Tables[0].Rows[0]["Address"].ToString();
            }

        public void UpdateUser()
            {
            string sql = "select * from UserTable where ID ='" + Admin.textBoxSearch_id.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
                {
                sql = @"update UserTable
                set FirstName = '" + Admin.textBoxUPFirstName.Text + @"',
                LastName = '" + Admin.textBoxUPLastName.Text + @"',
                Department = '" + Admin.comboBoxUPDepartment.Text + @"',
                Section = '" + Admin.textBoxUPSection.Text + @"',
                Course = '" + Admin.textBoxUPCourse.Text + @"',
                StudentID = '" + Admin.textBoxUPStudentId.Text + @"',
                UserName = '" + Admin.textBoxUPUserName.Text + @"',
                Email = '" + Admin.textBoxUPEmail.Text + @"',
                Address = '" + Admin.textBoxUPAddress.Text + @"'
                where StudentID = '" + Admin.textBoxSearch_id.Text + "';";
                }
            try
                {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Upgradation Done.");
                Admin.DisplayAllUser();
                }
            catch (Exception exc)
                {
                MessageBox.Show("Error: " + exc.Message);
                }
            }

        public void DeleteUser()
            {
            string id = Admin.dgvDeleteUser.CurrentRow.Cells["uid"].Value.ToString();
            //MessageBox.Show(id);
            //int idd = Convert.ToInt32(id);
            string sql = "delete from UserTable where ID = '" + id + "';";
            try
                {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion Done.");
                Admin.DisplayAllUser();
                }
            catch (Exception exc)
                {
                MessageBox.Show("Error: " + exc.Message);
                }
           
            }

        public void CreateNotice()
            {
            DateTime dt = DateTime.Now;

            string sql = @"insert into NoticeTable 
            values ('" + Admin.textBoxNoticeBox.Text + "','" + dt + "');";
            try
                {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Notice Created.");
                Admin.DisplayAllUser();
                }
            catch (Exception exc)
                {
                MessageBox.Show("Error: " + exc.Message);
                }
            Admin.textBoxNoticeBox.Text = "";
            }
        public bool validComplain()
            {
            string sql = "select * from ComplainTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            if (this.Ds.Tables[0].Rows.Count > 0)
                {
                this.ShowComplains();
                return true;
                }
            else
                {

                MessageBox.Show("No Complains!");
                return false;
                }


            }

        public DataSet GradeSubmit(string sub)
            {

            if (sub=="submit" )
                {

                string sql = @"update StudentGrade
                set Grade = '" + Admin.comboBoxGrade.Text + @"'
                where StudentId = '" + Admin.textBoxSearchid.Text + "';";
                try
                    {
                    this.Da.ExecuteUpdateQuery(sql);
                    MessageBox.Show("Grade Submitted");
                    Admin.DisplayAllUser();
                    }
                catch (Exception exc)
                    {
                    MessageBox.Show("Error: " + exc.Message);
                    }
                
                }
            else if (sub == "search")
                {
                string sql = "select * from StudentGrade where StudentId = '" + Admin.textBoxSearchid.Text + "';";
                this.Ds = this.Da.ExecuteQuery(sql);
                
                }
            return this.Ds;
            }

        public bool PollExists()
            {
            string sql = "select * from PollTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            if (this.Ds.Tables[0].Rows.Count < 1)
                {
                MessageBox.Show("Nothing To Show");
                return false;
                }
            else
                {
                return true;
                }
            }

        public void ShowPollResult()
            {
            string sql = "select * from PollTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            Admin.textBoxPollDetail.Text = this.Ds.Tables[0].Rows[0]["PollTitles"].ToString();
            Admin.textBoxOptionA.Text = this.Ds.Tables[0].Rows[0]["option1"].ToString();
            Admin.textBoxOptionB.Text = this.Ds.Tables[0].Rows[0]["option2"].ToString();
            Admin.textBoxOptionC.Text = this.Ds.Tables[0].Rows[0]["option3"].ToString();
            Admin.textBoxOptionD.Text = this.Ds.Tables[0].Rows[0]["option4"].ToString();
            Admin.textBoxOptionE.Text = this.Ds.Tables[0].Rows[0]["option5"].ToString();

            sql = "select sum(ChosenOption1) from PollResultTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            Admin.textBoxResultA.Text = this.Ds.Tables[0].Rows[0][0].ToString();
            sql = "select sum(ChosenOption2) from PollResultTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            Admin.textBoxResultB.Text = this.Ds.Tables[0].Rows[0][0].ToString();
            sql = "select sum(ChosenOption3) from PollResultTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            Admin.textBoxResultC.Text = this.Ds.Tables[0].Rows[0][0].ToString();
            sql = "select sum(ChosenOption4) from PollResultTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            Admin.textBoxResultD.Text = this.Ds.Tables[0].Rows[0][0].ToString();
            sql = "select sum(ChosenOption5) from PollResultTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            Admin.textBoxResultE.Text = this.Ds.Tables[0].Rows[0][0].ToString();
            }

        public void PollSubmit()
            {
            string sql;
            sql = "delete from PollTable";
            this.Da.ExecuteUpdateQuery(sql);
            sql = "delete from PollResultTable";
            this.Da.ExecuteUpdateQuery(sql);
            sql = "insert into PollTable values('" + Admin.textBoxPollTitle.Text + "','" + Admin.textBoxOption1.Text + "','" + Admin.textBoxOption2.Text + "','" + Admin.textBoxOption3.Text + "','" + Admin.textBoxOption4.Text + "','" + Admin.textBoxOption5.Text + "')";
            this.Da.ExecuteUpdateQuery(sql);
            }


        public void ShowComplains()
            {
            string sql = "select * from ComplainTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            Admin.dgvComplain.AutoGenerateColumns = false;
            Admin.dgvComplain.DataSource = this.Ds.Tables[0];

            }

        public void DeleteNotice()
            {
            string notices = Admin.dgvDeleteNotice.CurrentRow.Cells["notice"].Value.ToString();
            //MessageBox.Show(id);
            //int idd = Convert.ToInt32(id);
            string sql = "delete from NoticeTable where NoticeDetails = '" + notices + "';";
            try
                {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Deletion Done.");
                Admin.DisplayAllUser();
                }
            catch (Exception exc)
                {
                MessageBox.Show("Error: " + exc.Message);
                }
            }

        public DataSet DeleteUserClick()
            {
            string sql = "select * from UserTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
            }

        public DataSet DeleteNoticeClick()
            {
            string sql = "select * from NoticeTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            return this.Ds;
            }

        }
    }
