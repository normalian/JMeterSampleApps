using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JMeterApp.Common.Models;

namespace JMeterApp.WebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                Repeater1.DataSource = VoteCandidateFactory.VoteCandidates;
                Repeater1.DataBind();
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = e.Item.ItemIndex;
            Session["Id"] = id;
            Response.Redirect("~/Select.aspx", true);
        }
    }
}