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
            if (!IsPostBack)
            {
                evalQ1.SelectedIndex = 2;
                evalQ2.SelectedIndex = 2;
                evalQ3.SelectedIndex = 2;
                evalQ4.SelectedIndex = 2;
                evalQ5.SelectedIndex = 2;
            }
        }
        protected void submitForm(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ITCapEvalVM;Initial Catalog=EvalDatabase;Integrated Security=True");
            FormData _formData = new FormData();
            _formData.FillData(evalQ1.SelectedIndex+1, commentBox1.Text, evalQ2.SelectedIndex+1,commentBox2.Text, evalQ3.SelectedIndex+1, commentBox3.Text, evalQ4.SelectedIndex+1, commentBox4.Text, evalQ5.SelectedIndex+1,commentBox5.Text);

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Peer_Review (Contribution,Contribution_Comment,Communication,Communication_Comment,Teamwork,Teamwork_Comment,General,General_Comment,Overall,Overall_Comment) VALUES (@Contribution,@Contribution_Comment,@Communication,@Communication_Comment,@Teamwork,@Teamwork_Comment,@General,@General_Comment,@Overall,@Overall_Comment)", con);
            cmd.Parameters.AddWithValue("@Contribution", _formData.Contribution);
            cmd.Parameters.AddWithValue("@Contribution_Comment", _formData.Contribution_Comment);
            cmd.Parameters.AddWithValue("@Communication", _formData.Communication);
            cmd.Parameters.AddWithValue("@Communication_Comment", _formData.Communication_Comment);
            cmd.Parameters.AddWithValue("@Teamwork", _formData.Teamwork);
            cmd.Parameters.AddWithValue("@Teamwork_Comment", _formData.Teamwork_Comment);
            cmd.Parameters.AddWithValue("@General", _formData.General);
            cmd.Parameters.AddWithValue("@General_Comment", _formData.General_Comment);
            cmd.Parameters.AddWithValue("@Overall", _formData.Overall);
            cmd.Parameters.AddWithValue("@Overall_Comment", _formData.Overall_Comment);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}