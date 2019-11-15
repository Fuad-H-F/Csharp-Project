using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labManagement.Repository;
using labManagement.Data;

namespace labManagement
    {
    public partial class UserPanel : Form
        {
        FormLogin flogin;
         string currentUser;

        UserRepository us;
        public string Currentuser
            {
            get
                {
                return this.currentUser;
                }
            set
                {
                this.currentUser = value;
                }

            }
       
        private DataSet Ds
            {
            get;
            set;
            }
        public UserPanel(FormLogin obj,string currentUser)
            {
            InitializeComponent();
            this.flogin = obj;
            this.currentUser = currentUser;
           
            this.ViewNoticePanel.Hide();
            this.us = new UserRepository(this);
            }

        private void buttonViewNotice_Click(object sender, EventArgs e)
            {
            this.Ds = this.us.ViewNotice();
            
            foreach (DataTable thisTable in this.Ds.Tables)
                {
                foreach (DataRow row in thisTable.Rows)
                    {
                    TextBox tbnotice = new TextBox();
                    tbnotice.Width = 595;
                    tbnotice.Height = 33;
                    tbnotice.ReadOnly = true;
                    tbnotice.WordWrap = true;
                    tbnotice.Multiline = true;
                    tbnotice.ScrollBars = ScrollBars.Vertical;
                   

                    TextBox tbdate = new TextBox();
                    tbdate.Width = 140;
                    tbdate.Height = 33;
                    tbdate.Enabled = false;

                  
                    flowLayoutPanelViewNotice.Controls.Add(tbnotice);
                    flowLayoutPanelViewNotice.Controls.Add(tbdate);

                    tbnotice.Text = row["NoticeDetails"].ToString();
                    tbdate.Text = row["NoticeDate"].ToString();
                    }
                }
           
            this.panel4.Show();
            this.ViewNoticePanel.Show();
            this.ViewPollPanel.Hide();
            this.ComplainPanel.Hide();
            this.viewGradePanel.Hide();
            }

       


        private void buttonViewPoll_Click(object sender, EventArgs e)
            {
            bool validStudent = this.us.ValidPollSubmit();
            if (validStudent)
                {
                buttonPollSubmit.Enabled = true;
                this.us.PollSubmit();
                //string sql = "select * from PollTable";
                //this.Ds = this.Da.ExecuteQuery(sql);
                //this.textBoxViewPoll.Text = this.Ds.Tables[0].Rows[0]["PollTitles"].ToString();
                //if (this.Ds.Tables[0].Rows[0]["option1"].ToString() != "")
                //    {
                //    radioButton1.Text = this.Ds.Tables[0].Rows[0]["option1"].ToString();
                //    radioButton1.Show();
                //    }
                //if (this.Ds.Tables[0].Rows[0]["option2"].ToString() != "")
                //    {
                //    radioButton2.Text = this.Ds.Tables[0].Rows[0]["option2"].ToString();
                //    radioButton2.Show();
                //    }
                //if (this.Ds.Tables[0].Rows[0]["option3"].ToString() != "")
                //    {
                //    radioButton3.Text = this.Ds.Tables[0].Rows[0]["option3"].ToString();
                //    radioButton3.Show();
                //    }
                //if (this.Ds.Tables[0].Rows[0]["option4"].ToString() != "")
                //    {
                //    radioButton4.Text = this.Ds.Tables[0].Rows[0]["option4"].ToString();
                //    radioButton4.Show();
                //    }
                //if (this.Ds.Tables[0].Rows[0]["option5"].ToString() != "")
                //    {
                //    radioButton5.Text = this.Ds.Tables[0].Rows[0]["option5"].ToString();
                //    radioButton5.Show();
                //    }

                this.panel4.Show();
                this.ViewNoticePanel.Show();
                this.ViewPollPanel.Show();
                this.ComplainPanel.Hide();
                this.viewGradePanel.Hide();

                }
            else
                {
                MessageBox.Show("You Have Already Submitted Your Poll");
                buttonPollSubmit.Enabled = false;

                }
            }
        private void buttonComplain_Click(object sender, EventArgs e)
            {
            this.panel4.Show();
            this.ViewNoticePanel.Show();
            this.ViewPollPanel.Show();
            this.ComplainPanel.Show();
            this.viewGradePanel.Hide();

            }
        private void buttonViewGrade_Click(object sender, EventArgs e)
            {

            this.us.ShowCurrentGrade();
            this.panel4.Show();
            this.ViewNoticePanel.Show();
            this.ViewPollPanel.Show();
            this.ComplainPanel.Show();
            this.viewGradePanel.Show();
            }

        //private void ShowCurrentGrade()
        //    {
        //    string sql = "select * from UserTable where UserName='" + this.currentUser + "' ";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    string sid = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();
            
        //    sql = "select StudentId,Course,Sec,Grade from StudentGrade where StudentId='"+sid+"'";
        //    this.Ds = this.Da.ExecuteQuery(sql);

        //    this.labelStudentid.Text = this.Ds.Tables[0].Rows[0]["StudentId"].ToString();
        //    this.labelCourse.Text = this.Ds.Tables[0].Rows[0]["Course"].ToString();
        //    this.labelSection.Text = this.Ds.Tables[0].Rows[0]["Sec"].ToString();
        //    this.labelGrade.Text = this.Ds.Tables[0].Rows[0]["Grade"].ToString();
            

        //    }



        private void buttonExit_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void buttonLogout_Click(object sender, EventArgs e)
            {
            this.Hide();
            flogin.Show();
            }

        private void buttonPollSubmit_Click(object sender, EventArgs e)
            {
            this.us.PollSubmited();
            //if (radioButton1.Checked)
            //    {
            //    this.InsertionPollResult("ChosenOption1");
            //    }
            //else if (radioButton2.Checked)
            //    {
            //    this.InsertionPollResult("ChosenOption2");
            //    }
            //else if (radioButton3.Checked)
            //    {
            //    this.InsertionPollResult("ChosenOption3");
            //    }
            //else if (radioButton4.Checked)
            //    {
            //    this.InsertionPollResult("ChosenOption4");
            //    }
            //else if (radioButton5.Checked)
            //    {
            //    this.InsertionPollResult("ChosenOption5");
            //    }
            this.panel4.Show();
            this.ViewNoticePanel.Hide();
            this.ViewPollPanel.Hide();
            this.ComplainPanel.Hide();
            this.viewGradePanel.Hide();
            }
        //private void InsertionPollResult(string colName)
        //    {

        //    string sql = "select * from UserTable where UserName='"+this.currentUser+"' ";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //    string sid = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();
        //    sql = @"insert into PollResultTable(StudentId,["+colName+"]) values ('" + sid + "',1) ";

        //    try
        //        {
        //        this.Da.ExecuteUpdateQuery(sql);
        //         MessageBox.Show("Submission Done.");
                
        //        }
        //    catch (Exception exc)
        //        {
        //        MessageBox.Show("Error: " + exc.Message);
        //        }
            


        //    }

       
      

        //private bool ValidPollSubmit()
        //    {
        //    string sql = "select * from UserTable where UserName='" + this.currentUser + "' ";
        //    this.Ds = this.Da.ExecuteQuery(sql);
        //     string sid = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();
        //    sql = "select * from PollResultTable where StudentId = '" + sid + "' ";
        //    this.Ds = this.Da.ExecuteQuery(sql);


        //    if (this.Ds.Tables[0].Rows.Count > 0)
        //        {
        //        return false;
        //        }
        //    else
        //        {
                
        //        return true;
        //        }
        //    }

        private void buttonSubmitComplain_Click(object sender, EventArgs e)
            {
            //string sql = "select * from UserTable where UserName='" + this.currentUser + "' ";
            //this.Ds = this.Da.ExecuteQuery(sql);
            //string sid = this.Ds.Tables[0].Rows[0]["StudentID"].ToString();
            //DateTime dt = DateTime.Now;
            //sql = @"insert into ComplainTable values('"+sid+"','"+this.textBoxComplain.Text+"','"+dt+"')";
            //try
            //    {
            //    this.Da.ExecuteUpdateQuery(sql);
            //    MessageBox.Show("Complain Submission Done.");

            //    }
            //catch (Exception exc)
            //    {
            //    MessageBox.Show("Error: " + exc.Message);
            //    }
            this.us.Complain();
            this.textBoxComplain.Text = "";
            


            }

        

       
       

       
        }
    }
