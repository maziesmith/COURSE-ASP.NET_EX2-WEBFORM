

namespace COURSE_ASP.NET_EX2_WEBFORM
{
    using System;
    using System.Data;

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
            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha");

            dt.Columns.Add("Cuota");
            dt.Columns.Add("Saldo");


            var price= txtPrice.Text;
            var quote = "";
            if (rdr6.Checked == false && rdr12.Checked == false)
                quote = rdr18.Text;
            if (rdr12.Checked == false && rdr18.Checked == false)
                quote = rdr6.Text;
            if (rdr6.Checked == false && rdr18.Checked == false)
                quote = rdr12.Text;

            Session["data"] = price+"|"+quote;
            Response.Redirect("Report.aspx");
        }
    }
}