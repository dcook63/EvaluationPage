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
            studentList.Items.Clear();

            try
            {
                string i = groupList.SelectedValue;
                string query = @"SELECT 
                                    FirstName, LastName
                                From
                                    Project_Assignment
                                INNER JOIN
                                    Student ON Student.Student_ID = Project_Assignment.Student_ID
                                INNER JOIN
                                    Project ON Project.Project_ID = Project_Assignment.Project_ID
                                WHERE
                                    Project.Project_No = " + i;
                DataTable revieweeTable = new DataTable();
                SqlDataAdapter studentdata = new SqlDataAdapter(query, con);
                studentdata.Fill(revieweeTable);
                studentList.DataSource = revieweeTable;
                studentList.DataTextField = "FirstName";
                studentList.DataValueField = "FirstName";
                studentList.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Method is linked to .aspx button. Look for "OnClick" in .aspx file to see link
        protected void SubmitForm(object sender, EventArgs e)
        {
            FormData _formData = new FormData(); //Use this class to store variables obtained from Web Form

            SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Presentation_Review (Poster, Poster_Comment, Teamtalk, Teamtalk_Comment, Slides, Slides_Comment, Presentation, Presentation_Comment, Deliverables, Deliverables_Comment, Softskills, Softskills_Comment, Overall) VALUES (@Poster, @Poster_Comment, @Teamtalk, @Teamtalk_Comment, @Slides, @Slides_Comment, @Presentation, @Presentation_Comment, @Deliverables, @Deliverables_Comment, @Softskills, @Softskills_Comment, @Overall)", con);
            cmd.Parameters.AddWithValue("@Poster, @Poster_Comment, @Teamtalk, @Teamtalk_Comment, @Slides, @Slides_Comment, @Presentation, @Presentation_Comment, @Deliverables, @Deliverables_Comment, @Softskills, @Softskills_Comment, @Overall", _formData.Contribution);
            cmd.ExecuteNonQuery();
        }
    }
}