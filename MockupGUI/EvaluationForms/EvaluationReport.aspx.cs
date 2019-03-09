using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

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
                    BoundField contribution = new BoundField();
                    contribution.DataField = "Contribution";
                    contribution.HeaderText = "Contribution";
                    form = "Peer_Review";
                    scLabel.Text = ("Scores For Peer Evaluation");
                    groups.Columns.Add(contribution);
                }

                else if (form == "Sponsor Evaluation")
                {
                    BoundField clarity = new BoundField();
                    clarity.DataField = "Clarity";
                    clarity.HeaderText = "Clarity";
                    form = "Sponsor_Eval";
                    scLabel.Text = ("Scores For Sponsor Evaluation");
                    groups.Columns.Add(clarity);
                }
                    
                else if (form == "Presentation Evaluation")
                {
                    BoundField poster = new BoundField();
                    poster.DataField = "Poster";
                    poster.HeaderText = "Poster";
                    form = "Presentation_Eval";
                    scLabel.Text = ("Scores For Presentation Evaluation");
                    groups.Columns.Add(poster);
                }

                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM " + form, con);
                DataTable table = new DataTable();
                data.Fill(table);
                groups.DataSource = table;
                groups.DataBind();
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