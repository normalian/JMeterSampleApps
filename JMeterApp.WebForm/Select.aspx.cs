using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JMeterApp.Common.Models;

namespace JMeterApp.WebForm
{
    public partial class Select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ID が存在した場合、正常な遷移とみなして画面の描画領域を初期化
            int id = -1;
            if (Session["id"] != null && int.TryParse(Session["id"].ToString(), out id) == true)
            {

                var model = VoteCandidateFactory.VoteCandidates[id];
                Comment.Text = string.Format("私 {0} 大好き！！ (:.;ﾟ;Д;ﾟ;.:)ﾊｧﾊｧ", model.Name);
                CharImg.ImageUrl = model.ImgUrl;
                CharName.Text = model.Name;
            }
            else
            {
                Response.Redirect("~/");
            }
        }

        protected void VoteButton_Click(object sender, EventArgs e)
        {
            Session["Comment"] = Comment.Text;
            Response.Redirect("~/End.aspx");
        }
    }
}