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
    public partial class PresentationReview : System.Web.UI.Page
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
		                                Title, Project_No, Project_ID
	                                From
		                                Project";


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
		                                Title, Project_No, Project_ID
	                                From
		                                Project";

            SqlDataAdapter groupdata = new SqlDataAdapter(query, con);
            groupdata.Fill(grouptable);

            FormData _formData = new FormData(); //Use this class to store variables obtained from Web Form
            string FName = FNameInput.Text;
            string LName = LNameInput.Text;
            string Project_ID = grouptable.Rows[groupList.SelectedIndex]["Project_ID"].ToString();
            string Role = roleList.Text;
            _formData.FillPresentationData(question_one.SelectedIndex + 1, commentBox1.Text, question_two.SelectedIndex + 1, commentBox2.Text, question_three.SelectedIndex + 1, commentBox3.Text, question_four.SelectedIndex + 1, commentBox4.Text, question_five.SelectedIndex + 1, commentBox5.Text, question_six.SelectedIndex + 1, commentBox6.Text, question_seven.SelectedIndex + 1, commentBox7.Text, commentBox8.Text, commentBox9.Text, commentBox10.Text);

            MessageBox.Show(FName + LName + Project_ID + Role);

            SqlCommand cmd = new SqlCommand("INSERT INTO Presentation_Eval (Project_ID, FirstName, LastName, Role, Poster, Poster_Comment, Teamtalk, Teamtalk_Comment, Slides, Slides_Comment, Presentation, Presentation_Comment, Deliverables, Deliverables_Comment, Softskills, Softskills_Comment, Overall, Comment_on_Excellence, Comment_on_Weakness, Comment_on_website, Comment_on_Improvements) VALUES (@Project_ID, @FirstName, @LastName, @Role, @Poster, @Poster_Comment, @Teamtalk, @Teamtalk_Comment, @Slides, @Slides_Comment, @Presentation, @Presentation_Comment, @Deliverables, @Deliverables_Comment, @Softskills, @Softskills_Comment, @Overall, @Comment_on_Excellence, @Comment_on_Weakness, @Comment_on_website, @Comment_on_Improvements)", con);
            cmd.Parameters.AddWithValue("@Project_ID", Project_ID);
            cmd.Parameters.AddWithValue("@FirstName", FName);
            cmd.Parameters.AddWithValue("@LastName", LName);
            cmd.Parameters.AddWithValue("@Role", Role);
            cmd.Parameters.AddWithValue("@Poster", _formData.Poster);
            cmd.Parameters.AddWithValue("@Poster_Comment", _formData.Poster_Comment);
            cmd.Parameters.AddWithValue("@Teamtalk", _formData.Teamtalk);
            cmd.Parameters.AddWithValue("@Teamtalk_Comment", _formData.Teamtalk_Comment);
            cmd.Parameters.AddWithValue("@Slides", _formData.Slides);
            cmd.Parameters.AddWithValue("@Slides_Comment", _formData.Slides_Comment);
            cmd.Parameters.AddWithValue("@Presentation", _formData.Presentation);
            cmd.Parameters.AddWithValue("@Presentation_Comment", _formData.Presentation_Comment);
            cmd.Parameters.AddWithValue("@Deliverables", _formData.Deliverables);
            cmd.Parameters.AddWithValue("@Deliverables_Comment", _formData.Deliverables_Comment);
            cmd.Parameters.AddWithValue("@Softskills", _formData.Softskills);
            cmd.Parameters.AddWithValue("@Softskills_Comment", _formData.Softskills_Comment);
            cmd.Parameters.AddWithValue("@Overall", _formData.Overall);
            cmd.Parameters.AddWithValue("@Comment_on_Excellence", _formData.Comment_on_Excellence);
            cmd.Parameters.AddWithValue("@Comment_on_Weakness", _formData.Comment_on_Weakness);
            cmd.Parameters.AddWithValue("@Comment_on_website", _formData.Comment_on_website);
            cmd.Parameters.AddWithValue("@Comment_on_Improvements", _formData.Comment_on_Improvements);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}