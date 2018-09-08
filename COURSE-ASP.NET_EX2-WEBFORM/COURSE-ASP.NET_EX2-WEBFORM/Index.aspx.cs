

namespace COURSE_ASP.NET_EX2_WEBFORM
{
    using System;
 
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                string[] images = { "pc.png", "mic.png", "ipod.png" };
                ddlImages.DataSource = images;
                ddlImages.DataBind();
               
                Img1.ImageUrl = "Images/" + ddlImages.SelectedValue;
            }
            else
            {
                Img1.ImageUrl = "Images/" + ddlImages.SelectedValue;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["data"] = txtPrice.Text;
            Response.Redirect("Report.aspx");
        }
    }
}