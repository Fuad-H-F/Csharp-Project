using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using labManagement.Repository;
using labManagement.Data;
namespace labManagement
    {
    public partial class AdminPanel : Form
        {
        FormLogin flogin;
        AdminRepository ad;
        private DataSet Ds
            {
            get;
            set;
            }
        
        public AdminPanel(FormLogin obj)
            {
            InitializeComponent();
            this.flogin = obj;
            this.panel4.Show();
            this.panelRegistration.Hide();
            this.ViewPollResultPanel.Hide();
            
             this.ad = new AdminRepository(this);
           
            }

        public void DisplayAllUser()
            {
            this.Ds = ad.PopulateGridView();

            this.dgvDisplayUser.AutoGenerateColumns = false;
            this.dgvDisplayUser.DataSource = this.Ds.Tables[0];
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
       
            }
        
        

        private void buttonCreateUser_Click(object sender, EventArgs e)
            {
            this.textBoxFirstName.Text = "";
            this.textBoxLastName.Text = "";
            this.comboBoxDepartment.SelectedIndex = -1;
            this.textBoxCourse.Text = "";
            this.textBoxSection.Text = "";
            this.textBoxId.Text = "";
            this.textBoxUserName.Text = "";
            this.dateTimePickerBirthDate.Text = "";
            this.textBoxEmail.Text = "";
            this.textBoxAddress.Text = "";
            ////

            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Hide();
            this.SearchUserPanel.Hide();
            this.UpdateUserPanel.Hide();
            this.DeleteUserPanel.Hide();
            this.CreateNoticePanel.Hide();
            this.DeleteNoticePanel.Hide();
            this.ViewComplainPanel.Hide();
            this.CreatePollPanel.Hide();
            this.GradingPanel.Hide();
            this.ViewPollResultPanel.Hide();

            }

        private void buttonDisplayUser_Click(object sender, EventArgs e)
            {
            this.DisplayAllUser();
            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            this.SearchUserPanel.Hide();
            this.UpdateUserPanel.Hide();
            this.DeleteUserPanel.Hide();
            this.CreateNoticePanel.Hide();
            this.DeleteNoticePanel.Hide();
            this.ViewComplainPanel.Hide();
            this.CreatePollPanel.Hide();
            this.GradingPanel.Hide();
            this.ViewPollResultPanel.Hide();
            }

        private void buttonSearchUser_Click(object sender, EventArgs e)
            {
            this.textBoxSearchUser.Text = "";
            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            this.SearchUserPanel.Show();
            this.UpdateUserPanel.Hide();
            this.DeleteUserPanel.Hide();
            this.CreateNoticePanel.Hide();
            this.DeleteNoticePanel.Hide();
            this.ViewComplainPanel.Hide();
            this.CreatePollPanel.Hide();
            this.GradingPanel.Hide();
            this.ViewPollResultPanel.Hide();

            }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
            {
            this.textBoxSearch_id.Text = "";
            this.textBoxUPFirstName.Text = "";
            this.textBoxUPLastName.Text = "";
            this.comboBoxUPDepartment.Text = "";
            this.textBoxUPSection.Text = "";
            this.textBoxUPCourse.Text = "";
            this.textBoxUPStudentId.Text = "";
            this.textBoxUPUserName.Text = "";
            this.textBoxUPEmail.Text = "";
            this.textBoxUPAddress.Text = "";
            this.textBoxSearch_id.Text = "";
            
            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            this.SearchUserPanel.Show();
            this.UpdateUserPanel.Show();
            this.DeleteUserPanel.Hide();
            this.CreateNoticePanel.Hide();
            this.DeleteNoticePanel.Hide();
            this.ViewComplainPanel.Hide();
            this.CreatePollPanel.Hide();
            this.GradingPanel.Hide();
            this.ViewPollResultPanel.Hide();
            }


        private void buttonDeleteUser_Click(object sender, EventArgs e)
            {
            this.textBoxsid.Text = "";
            
           this.Ds = this.ad.DeleteUserClick();

            this.dgvDeleteUser.AutoGenerateColumns = false;
            this.dgvDeleteUser.DataSource = this.Ds.Tables[0];
            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            this.SearchUserPanel.Show();
            this.UpdateUserPanel.Show();
            this.DeleteUserPanel.Show();
            this.CreateNoticePanel.Hide();
            this.DeleteNoticePanel.Hide();
            this.ViewComplainPanel.Hide();
            this.CreatePollPanel.Hide();
            this.GradingPanel.Hide();
            this.ViewPollResultPanel.Hide();
            }
        

        private void buttonCreateNotice_Click(object sender, EventArgs e)
            {
            this.textBoxNoticeBox.Text = "";
            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            this.SearchUserPanel.Show();
            this.UpdateUserPanel.Show();
            this.DeleteUserPanel.Show();
            this.CreateNoticePanel.Show();
            this.DeleteNoticePanel.Hide();
            this.ViewComplainPanel.Hide();
            this.CreatePollPanel.Hide();
            this.GradingPanel.Hide();
            this.ViewPollResultPanel.Hide();
            }
        private void buttonDeleteNotice_Click(object sender, EventArgs e)
            {
            
            this.Ds = this.ad.DeleteNoticeClick();

            this.dgvDeleteNotice.AutoGenerateColumns = false;
            this.dgvDeleteNotice.DataSource = this.Ds.Tables[0];

            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            this.SearchUserPanel.Show();
            this.UpdateUserPanel.Show();
            this.DeleteUserPanel.Show();
            this.CreateNoticePanel.Show();
            this.DeleteNoticePanel.Show();
            this.ViewComplainPanel.Hide();
            this.CreatePollPanel.Hide();
            this.GradingPanel.Hide();
            this.ViewPollResultPanel.Hide();
            }
        private void buttonComplains_Click(object sender, EventArgs e)
            {

            bool valid=this.ad.validComplain();

            if (valid)
                {
                this.panel4.Show();
                this.panelRegistration.Show();
                this.DisplayUserPanel.Show();
                this.SearchUserPanel.Show();
                this.UpdateUserPanel.Show();
                this.DeleteUserPanel.Show();
                this.CreateNoticePanel.Show();
                this.DeleteNoticePanel.Show();
                this.ViewComplainPanel.Show();
                this.CreatePollPanel.Hide();
                this.GradingPanel.Hide();
                this.ViewPollResultPanel.Hide(); 
                }
           
            }
        private void buttonCreatePoll_Click(object sender, EventArgs e)
            {
            this.textBoxPollTitle.Text = "";
            this.textBoxOption1.Text = "";
            this.textBoxOption2.Text = "";
            this.textBoxOption3.Text = "";
            this.textBoxOption4.Text = "";
            this.textBoxOption5.Text = "";



            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            this.SearchUserPanel.Show();
            this.UpdateUserPanel.Show();
            this.DeleteUserPanel.Show();
            this.CreateNoticePanel.Show();
            this.DeleteNoticePanel.Show();
            this.ViewComplainPanel.Show();
            this.CreatePollPanel.Show();
            this.GradingPanel.Hide();
            this.ViewPollResultPanel.Hide();
            }
        private void buttonGrading_Click(object sender, EventArgs e)
            {
            this.textBoxSearchid.Text = "";
            this.comboBoxGrade.SelectedIndex = -1;
            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            this.SearchUserPanel.Show();
            this.UpdateUserPanel.Show();
            this.DeleteUserPanel.Show();
            this.CreateNoticePanel.Show();
            this.DeleteNoticePanel.Show();
            this.ViewComplainPanel.Show();
            this.CreatePollPanel.Show();
            this.GradingPanel.Show();
            this.ViewPollResultPanel.Hide();
            }
        private void buttonViewPollResult_Click(object sender, EventArgs e)
            {

            bool pollExists=this.ad.PollExists();
            if (pollExists)
                {
                
                this.ad.ShowPollResult();                
                }
            this.panel4.Show();
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            this.SearchUserPanel.Show();
            this.UpdateUserPanel.Show();
            this.DeleteUserPanel.Show();
            this.CreateNoticePanel.Show();
            this.DeleteNoticePanel.Show();
            this.ViewComplainPanel.Show();
            this.CreatePollPanel.Show();
            this.GradingPanel.Show();
            this.ViewPollResultPanel.Show();
            }
    



        private void buttonExit_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void buttonLogout_Click(object sender, EventArgs e)
            {
            this.Hide();
            flogin.Show();
            }

        private void buttonRegister_Click(object sender, EventArgs e)
            {

//            string randPassword = this.RandomPass();
//                string  sql = @"insert into UserTable 
//            values ('" +this.textBoxFirstName.Text + "','" + this.textBoxLastName.Text + "','" + this.comboBoxDepartment.Text + "','" + this.textBoxCourse.Text + "','" + this.textBoxSection.Text + "','" + this.textBoxId.Text + "','" + this.textBoxUserName.Text + "','" + randPassword + "','" + this.dateTimePickerBirthDate.Text + "','" + this.textBoxEmail.Text + "','" + this.textBoxAddress.Text + "');";
//            try
//                {
//                this.Da.ExecuteUpdateQuery(sql);
//                MessageBox.Show("Registration Done.");
//                this.DisplayAllUser();
//                }
//            catch (Exception exc)
//                {
//                MessageBox.Show("Error: " + exc.Message);
//                }

            
            ///////////////////////////
//            string t = "";
//            sql = @"insert into StudentGrade
//            values ('" + this.textBoxFirstName.Text + "','" + this.textBoxId.Text + "','" + this.textBoxCourse.Text + "','" + this.textBoxSection.Text + "','" + t + "');";
//            try
//                {
//                this.Da.ExecuteUpdateQuery(sql);

//                this.DisplayAllUser();
//                }
//            catch (Exception exc)
//                {
//                MessageBox.Show("Error: " + exc.Message);
//                }
            //////////////////////////
            ad.AdminRegister();
               this.textBoxFirstName.Text ="";
            this.textBoxLastName.Text ="";
            this.comboBoxDepartment.SelectedIndex =-1;
            this.textBoxCourse.Text ="";
            this.textBoxSection.Text="";
            this.textBoxId.Text ="";
            this.textBoxUserName.Text ="";
             this.dateTimePickerBirthDate.Text ="";
            this.textBoxEmail.Text="";
            this.textBoxAddress.Text = "";




            }

        private void textBoxSearchUser_TextChanged(object sender, EventArgs e)
            {

            this.Ds=this.ad.SearchUser();
           

            this.dgvDisplaySearchedUser.AutoGenerateColumns = false;
            this.dgvDisplaySearchedUser.DataSource = this.Ds.Tables[0];
            this.panelRegistration.Show();
            this.DisplayUserPanel.Show();
            }

        
        private void buttonSearch_Click(object sender, EventArgs e)
            {

            this.ad.UpdateSearchUser();
            //string sid = this.textBoxSearch_id.Text;
            //string sql = "select * from UserTable where StudentID = '" + sid + "';";

            //this.Ds = this.Da.ExecuteQuery(sql);

            //this.textBoxUPFirstName.Text = this.Ds.Tables[0].Rows[0]["FirstName"].ToString();
            //this.textBoxUPLastName.Text = this.Ds.Tables[0].Rows[0]["LastName"].ToString();
            //this.comboBoxUPDepartment.Text = this.Ds.Tables[0].Rows[0]["Department"].ToString();
            //this.textBoxUPCourse.Text = this.Ds.Tables[0].Rows[0]["Course"].ToString();
            //this.textBoxUPSection.Text = this.Ds.Tables[0].Rows[0]["Section"].ToString();
            //this.textBoxUPStudentId.Text = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();
            //this.textBoxUPUserName.Text = this.Ds.Tables[0].Rows[0]["UserName"].ToString();
            //this.dateTimePickerUPBirthDate.Text = this.Ds.Tables[0].Rows[0]["DateOfBirth"].ToString();
            //this.textBoxUPEmail.Text = this.Ds.Tables[0].Rows[0]["Email"].ToString();
            //this.textBoxUPAddress.Text = this.Ds.Tables[0].Rows[0]["Address"].ToString();
            

            }

       

        private void buttonUPUpdate_Click(object sender, EventArgs e)
            {
//                 string sql = "select * from UserTable where ID ='" + this.textBoxSearch_id.Text + "';";
//            this.Ds = this.Da.ExecuteQuery(sql);

//            if (this.Ds.Tables[0].Rows.Count == 1)
//                {
//                sql = @"update UserTable
//                set FirstName = '" + this.textBoxUPFirstName.Text + @"',
//                LastName = '" + this.textBoxUPLastName.Text + @"',
//                Department = '" + this.comboBoxUPDepartment.Text + @"',
//                Section = '" + this.textBoxUPSection.Text + @"',
//                Course = '" + this.textBoxUPCourse.Text + @"',
//                StudentID = '" + this.textBoxUPStudentId.Text + @"',
//                UserName = '" + this.textBoxUPUserName.Text + @"',
//                Email = '" + this.textBoxUPEmail.Text + @"',
//                Address = '" + this.textBoxUPAddress.Text + @"'
//                where StudentID = '" + this.textBoxSearch_id.Text + "';";
//                }
//                try
//                {
//                    this.Da.ExecuteUpdateQuery(sql);
//                    MessageBox.Show("Upgradation Done.");
//                    this.DisplayAllUser();
//                }
//                catch (Exception exc)
//                {
//                    MessageBox.Show("Error: " + exc.Message);
//                }
                  this.ad.UpdateUser();
                this.textBoxUPFirstName.Text = "";
                this.textBoxUPLastName.Text = "";
                this.comboBoxUPDepartment.Text = "";
                this.textBoxUPSection.Text = "";
                this.textBoxUPCourse.Text = "";
                this.textBoxUPStudentId.Text = "";
                this.textBoxUPUserName.Text = "";
                this.textBoxUPEmail.Text = "";
                this.textBoxUPAddress.Text = "";
                this.textBoxSearch_id.Text = "";
            //////////////
                this.DisplayAllUser();
                this.panel4.Show();
                this.panelRegistration.Show();
                this.DisplayUserPanel.Show();
                this.SearchUserPanel.Hide();
                this.UpdateUserPanel.Hide();
                this.DeleteUserPanel.Hide();


            }

        private void buttonDltUser_Click(object sender, EventArgs e)
            {
            this.textBoxsid.Text = "";
            this.ad.DeleteUser();
            //string id = this.dgvDeleteUser.CurrentRow.Cells["uid"].Value.ToString();
            ////MessageBox.Show(id);
            ////int idd = Convert.ToInt32(id);
            //string sql = "delete from UserTable where ID = '" +  id + "';";
            //try
            //    {
            //    this.Da.ExecuteUpdateQuery(sql);
            //    MessageBox.Show("Deletion Done.");
            //    this.DisplayAllUser();
            //    }
            //catch (Exception exc)
            //    {
            //    MessageBox.Show("Error: " + exc.Message);
            //    }
            //
            this.buttonDeleteUser_Click(sender,e);
            

            }

        private void buttonNoticeSubmit_Click(object sender, EventArgs e)
            {
            this.ad.CreateNotice();
//            DateTime dt = DateTime.Now;
            
//            string sql = @"insert into NoticeTable 
//            values ('" + this.textBoxNoticeBox.Text + "','" + dt + "');";
//            try
//                {
//                this.Da.ExecuteUpdateQuery(sql);
//                MessageBox.Show("Notice Created.");
//                this.DisplayAllUser();
//                }
//            catch (Exception exc)
//                {
//                MessageBox.Show("Error: " + exc.Message);
//                }
//            this.textBoxNoticeBox.Text = "";
            }

        private string RandomPass()
            {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');
            int num = rnd.Next(100, 999);
            string pass = randomChar + num.ToString();
            return pass;
            }
          

        
        private void buttonSubmitPoll_Click(object sender, EventArgs e)
            {

           
            this.CheckPollOptions();
            this.ad.PollSubmit();
            //string sql;
            //sql = "delete from PollTable";
            //this.Da.ExecuteUpdateQuery(sql);
            //sql = "delete from PollResultTable";
            //this.Da.ExecuteUpdateQuery(sql);
            //sql = "insert into PollTable values('" + this.textBoxPollTitle.Text + "','" + this.textBoxOption1.Text + "','" + this.textBoxOption2.Text + "','" + this.textBoxOption3.Text + "','" + this.textBoxOption4.Text + "','" + this.textBoxOption5.Text + "')";
            //this.Da.ExecuteUpdateQuery(sql);

            MessageBox.Show("Poll Submitted");
            this.textBoxPollTitle.Text = "";
            this.textBoxOption1.Text = "";
            this.textBoxOption2.Text = "";
            this.textBoxOption3.Text = "";
            this.textBoxOption4.Text = "";
            this.textBoxOption5.Text = "";

            }

        private void CheckPollOptions()
            {
            string temp = this.textBoxOption1.Text.Replace(" ", String.Empty);
            string temp1 = this.textBoxOption2.Text.Replace(" ", String.Empty);
            string temp2 = this.textBoxOption3.Text.Replace(" ", String.Empty);
            string temp3 = this.textBoxOption4.Text.Replace(" ", String.Empty);
            string temp4 = this.textBoxOption5.Text.Replace(" ", String.Empty);

            if (temp.Length < 1)
                {
                this.textBoxOption1.Text = null;
                }
            if (temp1.Length < 1)
                {
                this.textBoxOption2.Text = null;
                }
            if (temp2.Length < 1)
                {
                this.textBoxOption3.Text = null;
                }
            if (temp3.Length < 1)
                {
                this.textBoxOption4.Text = null;
                }
            if (temp4.Length < 1)
                {
                this.textBoxOption5.Text = null;
                }

            }

        private void buttonSearchid_Click(object sender, EventArgs e)
            {
            //string sql = "select * from StudentGrade where StudentId = '" + this.textBoxSearchid.Text + "';";
            //this.Ds = this.Da.ExecuteQuery(sql);
            string sea = "search";
            this.Ds=this.ad.GradeSubmit(sea);
            this.dgvGrading.AutoGenerateColumns = false;
            this.dgvGrading.DataSource = this.Ds.Tables[0];
            }

        private void buttonGradeSubmit_Click(object sender, EventArgs e)
            {
//            string sql = @"update StudentGrade
//                set Grade = '" + this.comboBoxGrade.Text + @"'
//                where StudentId = '" + this.textBoxSearchid.Text + "';"; 
//                try
//                {
//                this.Da.ExecuteUpdateQuery(sql);
//                MessageBox.Show("Grade Submitted");
//                this.DisplayAllUser();
//                }
//            catch (Exception exc)
//                {
//                MessageBox.Show("Error: " + exc.Message);
//                }
            string sub = "submit";
            this.ad.GradeSubmit(sub);
                this.buttonSearchid_Click(sender, e);
                this.comboBoxGrade.SelectedIndex = -1;
                this.textBoxSearchid.Text = "";

            }

        //private bool PollExists()
        //    {
        //    string sql = "select * from PollTable";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    if (this.Ds.Tables[0].Rows.Count < 1)
        //        {
        //        MessageBox.Show("Nothing To Show");
        //        return false;
        //        }
        //    else
        //        {
        //        return true;
        //        }
        //    }


        //private void ShowPollResult()
        //    {
        //    string sql = "select * from PollTable";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    this.textBoxPollDetail.Text = this.Ds.Tables[0].Rows[0]["PollTitles"].ToString();
        //    this.textBoxOptionA.Text=this.Ds.Tables[0].Rows[0]["option1"].ToString();
        //    this.textBoxOptionB.Text=this.Ds.Tables[0].Rows[0]["option2"].ToString();
        //    this.textBoxOptionC.Text=this.Ds.Tables[0].Rows[0]["option3"].ToString();
        //    this.textBoxOptionD.Text=this.Ds.Tables[0].Rows[0]["option4"].ToString();
        //    this.textBoxOptionE.Text = this.Ds.Tables[0].Rows[0]["option5"].ToString();

        //    sql = "select sum(ChosenOption1) from PollResultTable";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    this.textBoxResultA.Text = this.Ds.Tables[0].Rows[0][0].ToString();
        //    sql = "select sum(ChosenOption2) from PollResultTable";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    this.textBoxResultB.Text = this.Ds.Tables[0].Rows[0][0].ToString();
        //    sql = "select sum(ChosenOption3) from PollResultTable";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    this.textBoxResultC.Text = this.Ds.Tables[0].Rows[0][0].ToString();
        //    sql = "select sum(ChosenOption4) from PollResultTable";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    this.textBoxResultD.Text = this.Ds.Tables[0].Rows[0][0].ToString();
        //    sql = "select sum(ChosenOption5) from PollResultTable";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    this.textBoxResultE.Text = this.Ds.Tables[0].Rows[0][0].ToString();
        //    }


        //private bool validComplain()
        //    {
        //    string sql = "select * from ComplainTable";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    if (this.Ds.Tables[0].Rows.Count > 0)
        //        {
        //        this.ShowComplains();
        //        return true;
        //        }
        //    else
        //        {
                
        //        MessageBox.Show("No Complains!");
        //        return false;
        //        }

            
        //    }


        //private void ShowComplains()
        //    {
        //    string sql = "select * from ComplainTable";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    this.dgvComplain.AutoGenerateColumns = false;
        //    this.dgvComplain.DataSource = this.Ds.Tables[0];
 
        //    }

        private void buttonDltNotice_Click(object sender, EventArgs e)
            {

            this.ad.DeleteNotice();
            //string notices = this.dgvDeleteNotice.CurrentRow.Cells["notice"].Value.ToString();
            ////MessageBox.Show(id);
            ////int idd = Convert.ToInt32(id);
            //string sql = "delete from NoticeTable where NoticeDetails = '" + notices + "';";
            //try
            //    {
            //    this.Da.ExecuteUpdateQuery(sql);
            //    MessageBox.Show("Deletion Done.");
            //    this.DisplayAllUser();
            //    }
            //catch (Exception exc)
            //    {
            //    MessageBox.Show("Error: " + exc.Message);
            //    }
            this.buttonDeleteNotice_Click(sender, e);
   
            }

        
       

      

         

       

       

       
       
        }
    }
