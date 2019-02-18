using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MockupGUI
{
    public partial class SponsorReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            evalQ1.SelectedIndex = 2;
            evalQ2.SelectedIndex = 2;
            evalQ3.SelectedIndex = 2;
            evalQ4.SelectedIndex = 2;
        }
    }
}