using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MockupGUI
{
    public partial class SponsorReview : System.Web.UI.Page
    {
        public DataTable grouptable;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True");
            if (!IsPostBack)
            {
                groupList.Items.Clear();
                try
                {
                    //Clear Groups Dropdown List
                    grouptable = new DataTable();
                    string query = @"SELECT 
		                                Title, Project_No, Project.Sponsor_ID, Sponsor_Eval.Project_ID
	                                From
		                                Project
	                                INNER JOIN
		                                Sponsor_Eval ON Project.Project_ID = Sponsor_Eval.Project_ID";

                    SqlDataAdapter groupdata = new SqlDataAdapter(query, con);
                    groupdata.Fill(grouptable);
                    groupList.DataSource = grouptable;
                    groupList.DataTextField = "Title";
                    groupList.DataValueField = "Title";
                    groupList.DataBind();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        //Method is linked to .aspx button. Look for "OnClick" in .aspx file to see link
        protected void SubmitForm(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True");
            con.Open();
            grouptable = new DataTable();
            string query = @"SELECT 
		                        Title, Project_No, Project.Sponsor_ID, Sponsor_Eval.Project_ID
	                        From
		                        Project
	                        INNER JOIN
		                        Sponsor_Eval ON Project.Project_ID = Sponsor_Eval.Project_ID";

            SqlDataAdapter groupdata = new SqlDataAdapter(query, con);
            groupdata.Fill(grouptable);

            FormData _formData = new FormData(); //Use this class to store variables obtained from Web Form
            _formData.FillSponsorData(question_one.SelectedIndex+1, commentBox1.Text, question_two.SelectedIndex+1, commentBox2.Text, question_three.SelectedIndex + 1, commentBox3.Text, question_four.SelectedIndex + 1, commentBox4.Text, question_five.SelectedIndex + 1, commentBox5.Text, question_six.SelectedIndex + 1, commentBox6.Text, commentBox7.Text, commentBox8.Text, commentBox9.Text, commentBox10.Text, commentBox11.Text);
            _formData.Sponsor_ID = grouptable.Rows[groupList.SelectedIndex]["Sponsor_ID"].ToString();
            _formData.Project_ID = grouptable.Rows[groupList.SelectedIndex]["Project_ID"].ToString();
            
            SqlCommand cmd = new SqlCommand("INSERT INTO Sponsor_Eval (Sponsor_ID,Project_ID,Clarity, Clarity_Comment, Quality, Quality_Comment, Communication, Communication_Comment, Commitment, Commitment_Comment, Management, Management_Comment, Overall, Overall_Comment, Comment_on_Deliverables, Comment_on_Team,Feedback_on_Improvements,Value_to_Organization,Comment_on_Capstone) VALUES (@Sponsor_ID,@Project_ID,@Clarity, @Clarity_Comment, @Quality, @Quality_Comment, @Communication, @Communication_Comment, @Commitment, @Commitment_Comment, @Management,@Management_Comment, @Overall, @Overall_Comment, @Comment_on_Deliverables, @Comment_on_Team,@Feedback_on_Improvements,@Value_to_Organization,@Comment_on_Capstone)", con);
            cmd.Parameters.AddWithValue("@Sponsor_ID", _formData.Sponsor_ID);
            cmd.Parameters.AddWithValue("@Project_ID", _formData.Project_ID);
            cmd.Parameters.AddWithValue("@Clarity", _formData.Clarity);
            cmd.Parameters.AddWithValue("@Clarity_Comment", _formData.Clarity_Comment);
            cmd.Parameters.AddWithValue("@Quality", _formData.Quality);
            cmd.Parameters.AddWithValue("@Quality_Comment", _formData.Quality_Comment);
            cmd.Parameters.AddWithValue("@Communication", _formData.Communication);
            cmd.Parameters.AddWithValue("@Communication_Comment", _formData.Communication_Comment);
            cmd.Parameters.AddWithValue("@Commitment", _formData.Commitment);
            cmd.Parameters.AddWithValue("@Commitment_Comment", _formData.Commitment_Comment);
            cmd.Parameters.AddWithValue("@Management", _formData.Management);
            cmd.Parameters.AddWithValue("@Management_Comment", _formData.Management_Comment);
            cmd.Parameters.AddWithValue("@Overall", _formData.Overall);
            cmd.Parameters.AddWithValue("@Overall_Comment", _formData.Overall_Comment);
            cmd.Parameters.AddWithValue("@Comment_on_Deliverables", _formData.Comment_on_Deliverables);
            cmd.Parameters.AddWithValue("@Comment_on_Team", _formData.Comment_on_Team);
            cmd.Parameters.AddWithValue("@Feedback_on_Improvements", _formData.Feedback_on_Improvements);
            cmd.Parameters.AddWithValue("@Value_to_Organization", _formData.Value_to_Organization);
            cmd.Parameters.AddWithValue("@Comment_on_Capstone", _formData.Comment_on_Capstone);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}