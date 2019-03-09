﻿using System;
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
                    form = "Peer_Review";
                    scLabel.Text = ("Scores For Peer Evaluation");
                    searchup.Text = ("Search for Student");

                    BoundField contribution = new BoundField();
                    contribution.DataField = "Contribution";
                    contribution.HeaderText = "Contribution";

                    BoundField communication = new BoundField();
                    communication.DataField = "Communication";
                    communication.HeaderText = ". Communication .";

                    BoundField teamwork = new BoundField();
                    teamwork.DataField = "Teamwork";
                    teamwork.HeaderText = "Teamwork";

                    BoundField general = new BoundField();
                    general.DataField = "General";
                    general.HeaderText = "General";

                    BoundField overall = new BoundField();
                    overall.DataField = "Overall";
                    overall.HeaderText = "Overall";

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
                    searchup.Text = ("Search for Team");
                    groups.Columns.Add(clarity);
                }
                    
                else if (form == "Presentation Evaluation")
                {
                    BoundField poster = new BoundField();
                    poster.DataField = "Poster";
                    poster.HeaderText = "Poster";
                    form = "Presentation_Eval";
                    scLabel.Text = ("Scores For Presentation Evaluation");
                    searchup.Text = ("Search for Team");
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