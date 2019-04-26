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
            BoundField Space = new BoundField();
            Space.HeaderText = " ";
            Space.ItemStyle.Width = 20;

            using (SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True"))
            {
                con.Open();
                string form = FormSelect.SelectedItem.Text;

                int count = groups.Columns.Count;
                while(count > 1)
                {
                    groups.Columns.RemoveAt(count - 1);
                    --count;
                }

                if (form == "Peer Evaluation")
                {
                    form = "Peer_Review";
                    scLabel.Text = ("Scores For Peer Evaluation");
                    searchup.Text = ("Sort by Group");

                    BoundField Name = new BoundField();
                    Name.DataField = "Name";
                    Name.HeaderText = "Name";

                    BoundField reviewerName = new BoundField();
                    reviewerName.DataField = "rName";
                    reviewerName.HeaderText = "Reviewer Name";

                    BoundField contribution = new BoundField();
                    contribution.DataField = "Contribution";
                    contribution.HeaderText = "Contribution";

                    BoundField communication = new BoundField();
                    communication.DataField = "Communication";
                    communication.HeaderText = "Communication";

                    BoundField teamwork = new BoundField();
                    teamwork.DataField = "Teamwork";
                    teamwork.HeaderText = "Teamwork";

                    BoundField general = new BoundField();
                    general.DataField = "General";
                    general.HeaderText = "General";

                    BoundField overall = new BoundField();
                    overall.DataField = "Overall";
                    overall.HeaderText = "Overall";

                    groups.Columns.Add(Name);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(reviewerName);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(contribution);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(communication);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(teamwork);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(general);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(overall);
                }

                else if (form == "Sponsor Evaluation")
                {
                    form = "Sponsor_Eval";
                    scLabel.Text = ("Scores For Sponsor Evaluation");
                    searchup.Text = ("Sort by Group");

                    BoundField Name = new BoundField();
                    Name.DataField = "Name";
                    Name.HeaderText = "Sponsor Name";

                    BoundField clarity = new BoundField();
                    clarity.DataField = "Clarity";
                    clarity.HeaderText = "Clarity";

                    BoundField quality = new BoundField();
                    quality.DataField = "Quality";
                    quality.HeaderText = "Quality";

                    BoundField communication = new BoundField();
                    communication.DataField = "Communication";
                    communication.HeaderText = "Communication";

                    BoundField commitment = new BoundField();
                    commitment.DataField = "Commitment";
                    commitment.HeaderText = "Commitment";

                    BoundField management = new BoundField();
                    management.DataField = "Management";
                    management.HeaderText = "Management";

                    BoundField overall = new BoundField();
                    overall.DataField = "Overall";
                    overall.HeaderText = "Overall";

                    groups.Columns.Add(Name);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(clarity);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(quality);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(communication);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(commitment);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(management);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(overall);
                }
                    
                else if (form == "Presentation Evaluation")
                {
                    form = "Presentation_Eval";
                    scLabel.Text = ("Scores For Presentation Evaluation");
                    searchup.Text = ("Sort by Group");

                    BoundField title = new BoundField();
                    title.DataField = "Title";
                    title.HeaderText = "Title";

                    BoundField Name = new BoundField();
                    Name.DataField = "Name";
                    Name.HeaderText = "Name";

                    BoundField role = new BoundField();
                    role.DataField = "Role";
                    role.HeaderText = "Role";

                    BoundField poster = new BoundField();
                    poster.DataField = "Poster";
                    poster.HeaderText = "Poster";

                    BoundField teamtalk = new BoundField();
                    teamtalk.DataField = "Teamtalk";
                    teamtalk.HeaderText = "Teamtalk";

                    BoundField slides = new BoundField();
                    slides.DataField = "Slides";
                    slides.HeaderText = "Slides";

                    BoundField deliverables = new BoundField();
                    deliverables.DataField = "Deliverables";
                    deliverables.HeaderText = "Deliverables";

                    BoundField softskills = new BoundField();
                    softskills.DataField = "Softskills";
                    softskills.HeaderText = "Softskills";

                    BoundField overall = new BoundField();
                    overall.DataField = "Overall";
                    overall.HeaderText = "Overall";

                    groups.Columns.Add(title);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(role);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(Name);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(poster);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(teamtalk);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(slides);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(deliverables);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(softskills);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(overall);
                }

                if (!IsPostBack)
                {
                    try
                    {
                        //Clear Groups Dropdown List
                        groupList.Items.Clear();
                        DataTable grouptable = new DataTable();
                        SqlDataAdapter groupdata = new SqlDataAdapter("SELECT Title FROM Project", con);
                        groupdata.Fill(grouptable);
                        groupList.DataSource = grouptable;
                        groupList.DataTextField = "Title";
                        groupList.DataValueField = "Title";
                        
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
            //Page_Load(Server, e);
        }

        public string FormQueries(string form)
        {
            string query = "";
            if (form == "Peer_Review" && groupList.SelectedIndex == 0)
            {
                query =
                    @"SELECT 
	                            a.FirstName+ ' ' +a.LastName as Name, b.FirstName+ ' ' +b.LastName as rName, Contribution, Communication, Teamwork, General, Overall
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
	                            a.FirstName+ ' ' +a.LastName as Name, b.FirstName+ ' ' +b.LastName as rName, Contribution, Communication, Teamwork, General, Overall
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
            if (form == "Presentation_Eval" && groupList.SelectedIndex == 0)
            {
                query =
                    @"SELECT 
	                    Project.Title, FirstName+ ' ' +LastName as Name, Role, Poster, Teamtalk, Slides, Deliverables, Softskills, Overall
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
            else if(form == "Presentation_Eval")
            {
                query =
                    @"SELECT 
	                    Project.Title, FirstName+ ' ' +LastName as Name, Role, Poster, Teamtalk, Slides, Deliverables, Softskills, Overall
		                    From 
	                    Presentation_Eval
		                    INNER JOIN
	                    Project_Assignment
		                    ON
	                    Presentation_Eval.Project_ID = Project_Assignment.Project_ID
		                    INNER JOIN
	                    Project
		                    ON
	                    Project_Assignment.Project_ID = Project.Project_ID
                            WHERE
	                    Project.Project_No = +" + groupList.SelectedIndex;
            }
            if (form == "Sponsor_Eval" && groupList.SelectedIndex == 0)
            {
                query =
                    @"SELECT
		               Project_Sponsor.FirstName+ ' ' +Project_Sponsor.LastName as Name, Clarity, Quality, Communication, Commitment, Management, Overall
	                        FROM
		                Sponsor_Eval
	                        INNER JOIN
		                Project on Sponsor_Eval.Project_ID = Project.Project_ID
	                        INNER JOIN
		                Project_Sponsor on Sponsor_Eval.Sponsor_ID = Project_Sponsor.Sponsor_ID";
            }
            else if (form == "Sponsor_Eval")
            {
                query =
                    @"SELECT
		                Project_Sponsor.FirstName+ ' ' +Project_Sponsor.LastName as Name, Clarity, Quality, Communication, Commitment, Management, Overall
	                        FROM
		                Sponsor_Eval
	                        INNER JOIN
		                Project on Sponsor_Eval.Project_ID = Project.Project_ID
	                        INNER JOIN
		                Project_Sponsor on Sponsor_Eval.Sponsor_ID = Project_Sponsor.Sponsor_ID
                            WHERE
	                    Project.Project_No = +" + groupList.SelectedIndex;
            }
            return query;
        }

        protected void ShowDetails(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlButton btn = (System.Web.UI.HtmlControls.HtmlButton)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            string firstCellValue = gvr.Cells[1].Text;
            Session["FormType"] = FormSelect.SelectedItem.Text;
            Session["FirstCellVal"] = firstCellValue;
            Response.Redirect("DetailsPage.aspx");
        }
    }
}