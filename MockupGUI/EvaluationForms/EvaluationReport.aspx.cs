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
    public partial class EvaluationReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True"))
            {
                con.Open();
                string form = FormSelect.SelectedItem.Text;
                groups.Columns.Clear();
                if (form == "Peer Evaluation")
                {
                    form = "Peer_Review";
                    scLabel.Text = ("Scores For Peer Evaluation");
                    searchup.Text = ("Sort by Group");

                    BoundField firstName = new BoundField();
                    firstName.ItemStyle.Width = 100;
                    firstName.DataField = "FirstName";
                    firstName.HeaderText = "First Name";

                    BoundField lastName = new BoundField();
                    lastName.ItemStyle.Width = 100;
                    lastName.DataField = "LastName";
                    lastName.HeaderText = "Last Name";

                    BoundField reviewerFirstName = new BoundField();
                    reviewerFirstName.ItemStyle.Width = 100;
                    reviewerFirstName.DataField = "rFirstName";
                    reviewerFirstName.HeaderText = "Reviewer First Name";

                    BoundField reviewerLastName = new BoundField();
                    reviewerLastName.ItemStyle.Width = 100;
                    reviewerLastName.DataField = "rLastName";
                    reviewerLastName.HeaderText = "Reviewer Last Name";

                    BoundField contribution = new BoundField();
                    contribution.ItemStyle.Width = 100;
                    contribution.DataField = "Contribution";
                    contribution.HeaderText = "Contribution";

                    BoundField communication = new BoundField();
                    communication.ItemStyle.Width = 125;
                    communication.DataField = "Communication";
                    communication.HeaderText = "Communication";

                    BoundField teamwork = new BoundField();
                    teamwork.ItemStyle.Width = 80;
                    teamwork.DataField = "Teamwork";
                    teamwork.HeaderText = "Teamwork";

                    BoundField general = new BoundField();
                    general.ItemStyle.Width = 65;
                    general.DataField = "General";
                    general.HeaderText = "General";

                    BoundField overall = new BoundField();
                    overall.ItemStyle.Width = 65;
                    overall.DataField = "Overall";
                    overall.HeaderText = "Overall";

                    groups.Columns.Add(firstName);
                    groups.Columns.Add(lastName);
                    groups.Columns.Add(reviewerFirstName);
                    groups.Columns.Add(reviewerLastName);
                    groups.Columns.Add(contribution);
                    groups.Columns.Add(communication);
                    groups.Columns.Add(teamwork);
                    groups.Columns.Add(general);
                    groups.Columns.Add(overall);
                }

                else if (form == "Sponsor Evaluation")
                {
                    BoundField clarity = new BoundField();
                    clarity.DataField = "Clarity";
                    clarity.HeaderText = "Clarity";
                    form = "Sponsor_Eval";
                    scLabel.Text = ("Scores For Sponsor Evaluation");
                    searchup.Text = ("Sort by Group");
                    groups.Columns.Add(clarity);
                }
                    
                else if (form == "Presentation Evaluation")
                {
                    BoundField poster = new BoundField();
                    poster.DataField = "Poster";
                    poster.HeaderText = "Poster";
                    form = "Presentation_Eval";
                    scLabel.Text = ("Scores For Presentation Evaluation");
                    searchup.Text = ("Sort by Group");
                    groups.Columns.Add(poster);
                }

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
                        groupList.Items.Insert(0, new ListItem("All", "Default value"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

                try
                {
                    string query = "";
                    if(form == "Peer_Review")
                    {
                        query =
                            @"SELECT 
	                            a.FirstName, a.LastName, b.FirstName as rFirstName, b.LastName as rLastName, Contribution, Communication, Teamwork, General, Overall
		                            From 
	                            Peer_Review
		                            INNER JOIN 
	                            Student a
		                            ON 
	                            a.Student_ID = Peer_Review.Reviewee_ID
		                            INNER JOIN 
	                            Student b
		                            ON
	                            b.Student_ID = Peer_Review.Reviewer_ID";
                    }
                    if (form == "Presentation_Eval")
                    {
                        query =
                            @"SELECT
                                FirstName, LastName, Contribution, Communication, Teamwork, General, Overall
                                    From
                                Peer_Review
                                    INNER JOIN
                                Student ON Student.Student_ID = Peer_Review.Reviewee_ID";
                    }
                    if (form == "Sponsor_Eval")
                    {
                        query =
                            @"SELECT
                                FirstName, LastName, Contribution, Communication, Teamwork, General, Overall
                                    From
                                Peer_Review
                                    INNER JOIN
                                Student ON Student.Student_ID = Peer_Review.Reviewee_ID";
                    }
                    //Fill report 1
                    SqlDataAdapter data = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    data.Fill(table);
                    groups.DataSource = table;
                    groups.DataBind();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            } 
        }

        public void EvalReportSelect(object sender, EventArgs e)
        {
            string form = FormSelect.SelectedItem.Text;
            if (form == "Sponsor Evaluation")
                scLabel.Text = ("Scores For Sponsor Evaluation");
            else if (form == "Peer Evaluation")
                scLabel.Text = ("Scores For Peer Evaluation");
            else if (form == "Presentation Evaluation")
                scLabel.Text = ("Scores For Presentation Evaluation");
            Page_Load(Server, e);
        }
    }
}