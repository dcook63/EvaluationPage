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
                    form = "Sponsor_Eval";
                    scLabel.Text = ("Scores For Sponsor Evaluation");
                    searchup.Text = ("Sort by Group");

                    BoundField description = new BoundField();
                    description.ItemStyle.Width = 100;
                    description.DataField = "Description";
                    description.HeaderText = "Description";

                    BoundField firstName = new BoundField();
                    firstName.ItemStyle.Width = 100;
                    firstName.DataField = "FirstName";
                    firstName.HeaderText = "First Name";

                    BoundField lastName = new BoundField();
                    lastName.ItemStyle.Width = 100;
                    lastName.DataField = "LastName";
                    lastName.HeaderText = "Last Name";

                    BoundField clarity = new BoundField();
                    clarity.ItemStyle.Width = 100;
                    clarity.DataField = "Clarity";
                    clarity.HeaderText = "Clarity";

                    BoundField quality = new BoundField();
                    quality.ItemStyle.Width = 100;
                    quality.DataField = "Quality";
                    quality.HeaderText = "Quality";

                    BoundField communication = new BoundField();
                    communication.ItemStyle.Width = 125;
                    communication.DataField = "Communication";
                    communication.HeaderText = "Communication";

                    BoundField commitment = new BoundField();
                    commitment.ItemStyle.Width = 100;
                    commitment.DataField = "Commitment";
                    commitment.HeaderText = "Commitment";

                    BoundField management = new BoundField();
                    management.ItemStyle.Width = 100;
                    management.DataField = "Management";
                    management.HeaderText = "Management";

                    BoundField overall = new BoundField();
                    overall.ItemStyle.Width = 100;
                    overall.DataField = "Overall";
                    overall.HeaderText = "Overall";

                    groups.Columns.Add(description);
                    groups.Columns.Add(firstName);
                    groups.Columns.Add(lastName);
                    groups.Columns.Add(clarity);
                    groups.Columns.Add(quality);
                    groups.Columns.Add(communication);
                    groups.Columns.Add(commitment);
                    groups.Columns.Add(management);
                    groups.Columns.Add(overall);
                }
                    
                else if (form == "Presentation Evaluation")
                {
                    form = "Presentation_Eval";
                    scLabel.Text = ("Scores For Presentation Evaluation");
                    searchup.Text = ("Sort by Group");

                    BoundField description = new BoundField();
                    description.ItemStyle.Width = 100;
                    description.DataField = "Description";
                    description.HeaderText = "Description";

                    BoundField firstName = new BoundField();
                    firstName.ItemStyle.Width = 100;
                    firstName.DataField = "FirstName";
                    firstName.HeaderText = "First Name";

                    BoundField lastName = new BoundField();
                    lastName.ItemStyle.Width = 100;
                    lastName.DataField = "LastName";
                    lastName.HeaderText = "Last Name";

                    BoundField poster = new BoundField();
                    poster.ItemStyle.Width = 100;
                    poster.DataField = "Poster";
                    poster.HeaderText = "Poster";

                    BoundField teamtalk = new BoundField();
                    teamtalk.ItemStyle.Width = 100;
                    teamtalk.DataField = "Teamtalk";
                    teamtalk.HeaderText = "Teamtalk";

                    BoundField slides = new BoundField();
                    slides.ItemStyle.Width = 100;
                    slides.DataField = "Slides";
                    slides.HeaderText = "Slides";

                    BoundField deliverables = new BoundField();
                    deliverables.ItemStyle.Width = 100;
                    deliverables.DataField = "Deliverables";
                    deliverables.HeaderText = "Deliverables";

                    BoundField softskills = new BoundField();
                    softskills.ItemStyle.Width = 100;
                    softskills.DataField = "Softskills";
                    softskills.HeaderText = "Softskills";

                    BoundField overall = new BoundField();
                    overall.ItemStyle.Width = 100;
                    overall.DataField = "Overall";
                    overall.HeaderText = "Overall";

                    groups.Columns.Add(description);
                    groups.Columns.Add(firstName);
                    groups.Columns.Add(lastName);
                    groups.Columns.Add(poster);
                    groups.Columns.Add(teamtalk);
                    groups.Columns.Add(slides);
                    groups.Columns.Add(deliverables);
                    groups.Columns.Add(softskills);
                    groups.Columns.Add(overall);
                }

                if (!IsPostBack)
                {
                    try
                    {
                        //Clear Groups Dropdown List
                        groupList.Items.Clear();
                        DataTable grouptable = new DataTable();
                        SqlDataAdapter groupdata = new SqlDataAdapter("SELECT Description FROM Project", con);
                        groupdata.Fill(grouptable);
                        groupList.DataSource = grouptable;
                        groupList.DataTextField = "Description";
                        groupList.DataValueField = "Description";
                        
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
                    string query = FormQueries(form);
                    
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

        public string FormQueries(string form)
        {
            string query = "";
            if (form == "Peer_Review" && groupList.SelectedIndex == 0)
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
            else if ((form == "Peer_Review"))
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
	                            b.Student_ID = Peer_Review.Reviewer_ID
		                            INNER JOIN
	                            Project_Assignment
		                            ON
	                            a.Student_ID = Project_Assignment.Student_ID
		                            INNER JOIN
	                            Project
		                            ON
	                            Project_Assignment.Project_ID = Project.Project_ID
		                            WHERE
	                            Project.Project_No = +" + groupList.SelectedIndex;
            }
            if (form == "Presentation_Eval")
            {
                query =
                    @"SELECT 
	                            Project.Description, FirstName, LastName, Poster, Teamtalk, Slides, Deliverables, Softskills, Overall
		                            From 
	                            Presentation_Eval
		                            INNER JOIN
	                            Project_Assignment
		                            ON
	                            Presentation_Eval.Project_ID = Project_Assignment.Project_ID
		                            INNER JOIN
	                            Project
		                            ON
	                            Project_Assignment.Project_ID = Project.Project_ID";
            }
            if (form == "Sponsor_Eval")
            {
                query =
                    @"SELECT 
	                            Project.Description, Project_Sponsor.FirstName, Project_Sponsor.LastName, Clarity, Quality, Communication, Commitment, Management, Overall
		                            From 
	                            Sponsor_Eval
		                            INNER JOIN
	                            Project_Assignment
		                            ON
	                            Sponsor_Eval.Project_ID = Project_Assignment.Project_ID
		                            INNER JOIN
	                            Project
		                            ON
	                            Project_Assignment.Project_ID = Project.Project_ID
		                            INNER JOIN
	                            Project_Sponsor
		                            ON
	                            Sponsor_Eval.Sponsor_ID = Project_Sponsor.Sponsor_ID";
            }
            return query;
        }

    }
}