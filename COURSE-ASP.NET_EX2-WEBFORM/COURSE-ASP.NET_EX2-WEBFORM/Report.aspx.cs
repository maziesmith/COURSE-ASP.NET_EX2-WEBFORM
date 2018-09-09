
namespace COURSE_ASP.NET_EX2_WEBFORM
{
    using System;
    using System.Data;

    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["data"];
            this.GridView1.DataSource = dt;
            GridView1.DataBind();
            lblDate.Text = DateTime.Now.ToString();
            lblArt.Text = (String)Session["artefact"];
            lblPrice.Text=(String)Session["credit"];

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}