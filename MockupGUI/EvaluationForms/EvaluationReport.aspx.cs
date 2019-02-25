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
                if (form == "Sponsor Evaluation")
                    form = "Sponsor_Eval";
                else if (form == "Peer Evaluation")
                    form = "Peer_Review";
                else if (form == "Presentation Evaluation")
                    form = "Presentation_Eval";
                
                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Presentation_Eval", con);
                DataTable table = new DataTable();
                data.Fill(table);
                groups.DataSource = table;
                groups.DataBind();
            } 
        }

            
    }
}