using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JMeterApp.WebForm
{
    public partial class End : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Comment"] == null)
            {
                Response.Redirect("~/");
            }
            else
            {
                Comment.Text = Session["Comment"].ToString();
            }
        }
    }
}