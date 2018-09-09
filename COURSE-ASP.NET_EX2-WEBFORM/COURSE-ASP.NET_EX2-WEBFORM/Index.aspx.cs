

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
            string artefact = "";
            if (ddlImages.SelectedValue!= "pc.png"&& ddlImages.SelectedValue != "mic.png")
            {
                artefact = "IPOD";
            }
            if (ddlImages.SelectedValue != "ipod.png" && ddlImages.SelectedValue != "mic.png")
            {
                artefact = "LAPTOP";
            }
            if (ddlImages.SelectedValue != "pc.png" && ddlImages.SelectedValue != "ipod.png")
            {
                artefact = "MICROONDAS";
            }


            var price= txtPrice.Text;
            var quote = "";
            double interest = 0.0;
            if (rdr6.Checked == false && rdr12.Checked == false)
            {
                quote = rdr18.Text;
                interest = 0.60;
            }
            if (rdr12.Checked == false && rdr18.Checked == false)
            {
                quote = rdr6.Text;
                interest = 0.20;
            }
            if (rdr6.Checked == false && rdr18.Checked == false)
            {
                quote = rdr12.Text;
                interest = 0.40;
            }
            DateTime dcurrent = DateTime.Now;
            DateTime future;
            var _quote = Convert.ToDouble(price) / Convert.ToDouble(quote);
            var balance = (Convert.ToDouble(price)*interest)+ Convert.ToDouble(price);
            var priceCredit = balance;




            for (int m = 1; m <= Convert.ToInt16(quote); m++)
            {
                future = dcurrent.AddMonths(m);
               // interest =  (Convert.ToDouble(price)/Convert.ToDouble(quote)) * 0.40;
                balance -=  interest;
                //adicionar una fila a la tabla
                dt.Rows.Add(future.ToString("d"), _quote, balance);
            }
             Session["data"] = dt;
             Session["artefact"] = artefact;
            Session["credit"] = priceCredit.ToString();
            Response.Redirect("Report.aspx");
        }
    }
}