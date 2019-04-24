using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MockupGUI
{
    public partial class PeerReview : System.Web.UI.Page
    {
        public DataTable revieweeTable;
        public DataTable reviewerTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True");

            if (!IsPostBack)
            {
                try
                {
                    //Clear Groups Dropdown List
                    groupList.Items.Clear();

                    DataTable grouptable = new DataTable();
                    SqlDataAdapter groupdata = new SqlDataAdapter("SELECT Project_No FROM Project", con);
                    groupdata.Fill(grouptable);
                    groupList.DataSource = grouptable;
                    groupList.DataTextField = "Project_No";
                    groupList.DataValueField = "Project_No";
                    groupList.DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            //Clear Groups Dropdown List
            revieweeList.Items.Clear();
            reviewerList.Items.Clear();

            //Fill dd list for reviewees
            try
            {
                string i = groupList.SelectedValue;
                string query = @"SELECT 
                                    FirstName, LastName, Student.Student_ID
                                From
                                    Project_Assignment
                                INNER JOIN
                                    Student ON Student.Student_ID = Project_Assignment.Student_ID
                                INNER JOIN
                                    Project ON Project.Project_ID = Project_Assignment.Project_ID
                                WHERE
                                    Project.Project_No = " + i;
                revieweeTable = new DataTable();
                SqlDataAdapter studentdata = new SqlDataAdapter(query, con);
                studentdata.Fill(revieweeTable);
                revieweeList.DataSource = revieweeTable;
                revieweeList.DataTextField = "FirstName";
                revieweeList.DataValueField = "FirstName";
                revieweeList.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Fill dd list for reviewer
            try
            {
                string i = groupList.SelectedValue;
                string query = @"SELECT 
                                    FirstName, LastName, Student.Student_ID
                                From
                                    Project_Assignment
                                INNER JOIN
                                    Student ON Student.Student_ID = Project_Assignment.Student_ID
                                INNER JOIN
                                    Project ON Project.Project_ID = Project_Assignment.Project_ID
                                WHERE
                                    Project.Project_No = " + i;
                reviewerTable = new DataTable();
                SqlDataAdapter studentdata = new SqlDataAdapter(query, con);
                studentdata.Fill(reviewerTable);
                reviewerList.DataSource = reviewerTable;
                reviewerList.DataTextField = "FirstName";
                reviewerList.DataValueField = "FirstName";
                reviewerList.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Method is linked to .aspx button. Look for "OnClick" in .aspx file to see link
        protected void SubmitForm(object sender, EventArgs e)
        {
            //Get Student ID from Students
            FormData _formData = new FormData(); //Use this class to store variables obtained from Web 
            _formData.FillPeerData(question_one.SelectedIndex + 1, commentBox1.Text, question_two.SelectedIndex + 1, commentBox2.Text, question_three.SelectedIndex + 1, commentBox3.Text, question_four.SelectedIndex + 1, commentBox4.Text, question_five.SelectedIndex + 1, commentBox5.Text);
            FormData Reviewee = new FormData();
            Reviewee.Student = revieweeTable.Rows[revieweeList.SelectedIndex]["Student_ID"].ToString();
            FormData Reviewer = new FormData();
            Reviewer.Student = reviewerTable.Rows[reviewerList.SelectedIndex]["Student_ID"].ToString();

            SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Peer_Review (Reviewer_ID,Reviewee_ID,Contribution,Contribution_Comment,Communication,Communication_Comment,Teamwork,Teamwork_Comment,General,General_Comment,Overall,Overall_Comment) VALUES (@Reviewer_ID,@Reviewee_ID,@Contribution,@Contribution_Comment,@Communication,@Communication_Comment,@Teamwork,@Teamwork_Comment,@General,@General_Comment,@Overall,@Overall_Comment)", con);
            cmd.Parameters.AddWithValue("@Reviewee_ID", Reviewee.Student);
            cmd.Parameters.AddWithValue("@Reviewer_ID", Reviewer.Student);
            cmd.Parameters.AddWithValue("@Contribution", _formData.Contribution);
            cmd.Parameters.AddWithValue("@Contribution_Comment", _formData.Contribution_Comment);
            cmd.Parameters.AddWithValue("@Communication", _formData.Communication);
            cmd.Parameters.AddWithValue("@Communication_Comment", _formData.Communication_Comment);
            cmd.Parameters.AddWithValue("@Teamwork", _formData.Teamwork);
            cmd.Parameters.AddWithValue("@Teamwork_Comment", _formData.Teamwork_Comment);
            cmd.Parameters.AddWithValue("@General", _formData.General);
            cmd.Parameters.AddWithValue("@General_Comment", _formData.General_Comment);
            cmd.Parameters.AddWithValue("@Overall", _formData.Overall_Peer);
            cmd.Parameters.AddWithValue("@Overall_Comment", _formData.Overall_Peer_Comment);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}