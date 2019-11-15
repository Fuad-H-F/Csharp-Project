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
    class UserRepository
        {
        UserPanel User;
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
       public UserRepository( UserPanel User)
           {
           this.User = User;
           this.Da = new DataAccess();

           }
        public DataSet ViewNotice()
           {

           string sql = "select * from NoticeTable";
           this.Ds = this.Da.ExecuteQuery(sql);
           return this.Ds;
           }
        public void PollSubmited()
            {
            if (this.User.radioButton1.Checked)
                {
                this.InsertionPollResult("ChosenOption1");
                }
            else if (this.User.radioButton2.Checked)
                {
                this.InsertionPollResult("ChosenOption2");
                }
            else if (this.User.radioButton3.Checked)
                {
                this.InsertionPollResult("ChosenOption3");
                }
            else if (this.User.radioButton4.Checked)
                {
                this.InsertionPollResult("ChosenOption4");
                }
            else if (this.User.radioButton5.Checked)
                {
                this.InsertionPollResult("ChosenOption5");
                }
            }
        public void InsertionPollResult(string colName)
            {

            string sql = "select * from UserTable where UserName='" + this.User.Currentuser + "' ";
            this.Ds = this.Da.ExecuteQuery(sql);
            string sid = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();
            sql = @"insert into PollResultTable(StudentId,[" + colName + "]) values ('" + sid + "',1) ";

            try
                {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Submission Done.");

                }
            catch (Exception exc)
                {
                MessageBox.Show("Error: " + exc.Message);
                }



            }
        public void PollSubmit()
            {
            string sql = "select * from PollTable";
            this.Ds = this.Da.ExecuteQuery(sql);
            this.User.textBoxViewPoll.Text = this.Ds.Tables[0].Rows[0]["PollTitles"].ToString();
            if (this.Ds.Tables[0].Rows[0]["option1"].ToString() != "")
                {
                this.User.radioButton1.Text = this.Ds.Tables[0].Rows[0]["option1"].ToString();
                this.User.radioButton1.Show();
                }
            if (this.Ds.Tables[0].Rows[0]["option2"].ToString() != "")
                {
                this.User.radioButton2.Text = this.Ds.Tables[0].Rows[0]["option2"].ToString();
                this.User.radioButton2.Show();
                }
            if (this.Ds.Tables[0].Rows[0]["option3"].ToString() != "")
                {
                this.User.radioButton3.Text = this.Ds.Tables[0].Rows[0]["option3"].ToString();
                this.User.radioButton3.Show();
                }
            if (this.Ds.Tables[0].Rows[0]["option4"].ToString() != "")
                {
                this.User.radioButton4.Text = this.Ds.Tables[0].Rows[0]["option4"].ToString();
                this.User.radioButton4.Show();
                }
            if (this.Ds.Tables[0].Rows[0]["option5"].ToString() != "")
                {
                this.User.radioButton5.Text = this.Ds.Tables[0].Rows[0]["option5"].ToString();
                this.User.radioButton5.Show();
                }
            }
        public bool ValidPollSubmit()
            {
            string sql = "select * from UserTable where UserName='" + this.User.Currentuser + "' ";
            this.Ds = this.Da.ExecuteQuery(sql);
            string sid = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();
            sql = "select * from PollResultTable where StudentId = '" + sid + "' ";
            this.Ds = this.Da.ExecuteQuery(sql);


            if (this.Ds.Tables[0].Rows.Count > 0)
                {
                return false;
                }
            else
                {

                return true;
                }
            }

        public void Complain()
            {
            string sql = "select * from UserTable where UserName='" + this.User.Currentuser + "' ";
            this.Ds = this.Da.ExecuteQuery(sql);
            string sid = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();
            DateTime dt = DateTime.Now;
            sql = @"insert into ComplainTable values('" + sid + "','" + this.User.textBoxComplain.Text + "','" + dt + "')";
            try
                {
                this.Da.ExecuteUpdateQuery(sql);
                MessageBox.Show("Complain Submission Done.");

                }
            catch (Exception exc)
                {
                MessageBox.Show("Error: " + exc.Message);
                }

            
            }

        public void ShowCurrentGrade()
            {
            string sql = "select * from UserTable where UserName='" + this.User.Currentuser + "' ";
            this.Ds = this.Da.ExecuteQuery(sql);
            string sid = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();

            sql = "select StudentId,Course,Sec,Grade from StudentGrade where StudentId='" + sid + "'";
            this.Ds = this.Da.ExecuteQuery(sql);

            this.User.labelStudentid.Text = this.Ds.Tables[0].Rows[0]["StudentId"].ToString();
            this.User.labelCourse.Text = this.Ds.Tables[0].Rows[0]["Course"].ToString();
            this.User.labelSection.Text = this.Ds.Tables[0].Rows[0]["Sec"].ToString();
            this.User.labelGrade.Text = this.Ds.Tables[0].Rows[0]["Grade"].ToString();


            }




        }
    }
