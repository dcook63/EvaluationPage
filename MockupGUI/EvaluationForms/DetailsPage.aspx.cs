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
    public partial class DetailsPage : System.Web.UI.Page
    {
        public string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True"))
            {
                con.Open();

                int count = groups.Columns.Count;
                while (count > 0)
                {
                    groups.Columns.RemoveAt(count - 1);
                    --count;
                }
                var FirstCellVal = Session["FirstCellVal"];
                string formType = (string)Session["FormType"];

                BoundField Space = new BoundField();
                Space.HeaderText = " ";
                Space.ItemStyle.Width = 20;

                if (formType == "Peer Evaluation")
                {
                    BoundField reviewerName = new BoundField();
                    reviewerName.DataField = "rName";
                    reviewerName.HeaderText = "Reviewer Name";

                    BoundField contribution = new BoundField();
                    contribution.DataField = "Cont";
                    contribution.HeaderText = "Contribution";

                    BoundField communication = new BoundField();
                    communication.DataField = "Comm";
                    communication.HeaderText = "Communication";

                    BoundField teamwork = new BoundField();
                    teamwork.DataField = "Teamw";
                    teamwork.HeaderText = "Teamwork";

                    BoundField general = new BoundField();
                    general.DataField = "Gen";
                    general.HeaderText = "General";

                    BoundField overall = new BoundField();
                    overall.DataField = "Ovr";
                    overall.HeaderText = "Overall";

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

                    query =
                            @"SELECT 
	                            b.FirstName+ ' ' +b.LastName as rName, STR(Contribution) + ': ' + Contribution_Comment as Cont, 
	                            STR(Communication) + ': ' + Communication_Comment as Comm, STR(Teamwork) + ': ' + Teamwork_Comment as Teamw, STR(General) + ': ' + General_Comment as Gen, STR(Overall) + ': ' + Overall_Comment as Ovr
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
		                            WHERE 
	                            a.FirstName + ' ' + a.LastName = '" + FirstCellVal + "'";
                }
                if (formType == "Presentation Evaluation")
                {
                    BoundField Name = new BoundField();
                    Name.DataField = "Name";
                    Name.HeaderText = "Name";

                    BoundField role = new BoundField();
                    role.DataField = "Role";
                    role.HeaderText = "Role";

                    BoundField poster = new BoundField();
                    poster.DataField = "Post";
                    poster.HeaderText = "Poster";

                    BoundField teamtalk = new BoundField();
                    teamtalk.DataField = "TTalk";
                    teamtalk.HeaderText = "Teamtalk";

                    BoundField slides = new BoundField();
                    slides.DataField = "Slide";
                    slides.HeaderText = "Slides";

                    BoundField deliverables = new BoundField();
                    deliverables.DataField = "Deliv";
                    deliverables.HeaderText = "Deliverables";

                    BoundField softskills = new BoundField();
                    softskills.DataField = "SSkil";
                    softskills.HeaderText = "Softskills";

                    BoundField overall = new BoundField();
                    overall.DataField = "Ovr";
                    overall.HeaderText = "Overall";

                    BoundField COE = new BoundField();
                    COE.DataField = "Comment_on_Excellence";
                    COE.HeaderText = "Comment On Excellence";

                    BoundField COW = new BoundField();
                    COW.DataField = "Comment_on_Weakness";
                    COW.HeaderText = "Comment On Weakness";

                    BoundField COWeb = new BoundField();
                    COWeb.DataField = "Comment_on_website";
                    COWeb.HeaderText = "Comment On Website";

                    BoundField COI = new BoundField();
                    COI.DataField = "Comment_on_Improvements";
                    COI.HeaderText = "Comment On Improvements";
                    
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
                    groups.Columns.Add(Space);
                    groups.Columns.Add(COE);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(COW);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(COWeb);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(COI);

                    query =
                        @"SELECT 
	                        Project.Title, FirstName + ' ' + LastName as Name, Role, STR(Poster) + ': ' + Poster_Comment as Post, STR(Teamtalk) + ': ' + Teamtalk_Comment as TTalk, STR(Slides) + ': ' + 
	                        Slides_Comment as Slide, STR(Deliverables) + ': ' + Deliverables_Comment as Deliv, STR(Softskills) + ': ' + Softskills_Comment as SSkil, Overall as Ovr, Comment_on_Excellence,
	                        Comment_on_Weakness, Comment_on_website, Comment_on_Improvements
		                        From 
	                        Presentation_Eval
		                        INNER JOIN
	                        Project_Assignment
		                        ON
	                        Presentation_Eval.Project_ID = Project_Assignment.Project_ID
		                        INNER JOIN
	                        Project
		                        ON
	                        Project.Title = '" + FirstCellVal + "'";
                }

                if (formType == "Sponsor Evaluation")
                {
                    BoundField Clar = new BoundField();
                    Clar.DataField = "Clar";
                    Clar.HeaderText = "Clarity";

                    BoundField Qual = new BoundField();
                    Qual.DataField = "Qual";
                    Qual.HeaderText = "Quality";

                    BoundField Comm = new BoundField();
                    Comm.DataField = "Comm";
                    Comm.HeaderText = "Communication";

                    BoundField Commt = new BoundField();
                    Commt.DataField = "Commt";
                    Commt.HeaderText = "Commitment";

                    BoundField Manag = new BoundField();
                    Manag.DataField = "Manag";
                    Manag.HeaderText = "Management";

                    BoundField Ovr = new BoundField();
                    Ovr.DataField = "Ovr";
                    Ovr.HeaderText = "Overall";

                    BoundField COD = new BoundField();
                    COD.DataField = "Comment_on_Deliverables";
                    COD.HeaderText = "Comment On Deliverables";

                    BoundField COT = new BoundField();
                    COT.DataField = "Comment_on_Team";
                    COT.HeaderText = "Comment On Team";

                    BoundField FOI = new BoundField();
                    FOI.DataField = "Feedback_on_Improvements";
                    FOI.HeaderText = "Feedback On Improvements";

                    BoundField VTO = new BoundField();
                    VTO.DataField = "Value_to_Organization";
                    VTO.HeaderText = "Value To Organization";

                    BoundField COC = new BoundField();
                    COC.DataField = "Comment_on_Capstone";
                    COC.HeaderText = "Comment On Capstone";

                    groups.Columns.Add(Clar);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(Qual);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(Comm);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(Commt);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(Manag);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(Ovr);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(COD);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(COT);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(FOI);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(VTO);
                    groups.Columns.Add(Space);
                    groups.Columns.Add(COC);
                    groups.Columns.Add(Space);

                    query =
                        @"SELECT
	                        STR(Clarity) + ': ' + Clarity_Comment as Clar, STR(Quality) + ': ' + Quality_Comment as Qual, STR(Communication) + ': ' + Communication_Comment as Comm, STR(Commitment) + ': ' + 
	                        Commitment_Comment as Commt, STR(Management) + ': ' + Management_Comment as Manag, STR(Overall) + ': ' + Overall_Comment as Ovr, Comment_on_Deliverables, Comment_on_Team, 
	                        Feedback_on_Improvements, Value_to_Organization, Comment_on_Capstone
		                        FROM
	                        Sponsor_Eval
		                        INNER JOIN
	                        Project on Sponsor_Eval.Project_ID = Project.Project_ID
		                        INNER JOIN
	                        Project_Sponsor on Sponsor_Eval.Sponsor_ID = Project_Sponsor.Sponsor_ID
                                WHERE
                            Project_Sponsor.FirstName + ' ' + Project_Sponsor.LastName = '" + FirstCellVal + "'";

                }

                    try
                {
                    SqlDataAdapter data = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    data.Fill(table);
                    groups.DataSource = table;
                    groups.DataBind();
                    detailHeader.InnerText = "Detail View for " + FirstCellVal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        protected void Return(object sender, EventArgs e)
        {
            Response.Redirect("EvaluationReport.aspx");
        }
    }
}
