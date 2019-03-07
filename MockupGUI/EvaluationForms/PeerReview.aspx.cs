using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MockupGUI
{
    public partial class PeerReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If the page is requesting a post back it is simply asking if anything has been updated since the initial page load
            if (!IsPostBack)
            {
                //Set the default selected value in the dropdown menu to 2
                question_one.SelectedIndex = 4;
            }
        }
        //Method is linked to .aspx button. Look for "OnClick" in .aspx file to see link
        protected void SubmitForm(object sender, EventArgs e)
        {
            FormData _formData = new FormData(); //Use this class to store variables obtained from Web For

            /*
                    Example of how to insert data into a SQL Table
            
            SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Peer_Review (Contribution) VALUES (@Contribution)", con);
            cmd.Parameters.AddWithValue("@Contribution", _formData.Contribution);
            */
        }

        protected void Textbox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}