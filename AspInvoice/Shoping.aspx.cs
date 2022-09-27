using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AspInvoice
{
    public partial class Shoping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Display1();
        }
        //private void Display1()
        //{
        //    string conn = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
        //    SqlConnection sqlconn = new SqlConnection(conn);
        //    sqlconn.Open();
        //    string query = "select * from Product1";
        //    SqlCommand cmd = new SqlCommand(query, sqlconn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataSet dataset = new DataSet();
        //    adapter.Fill(dataset);
        //    GV3.DataSource = dataset.Tables[0];
        //    GV3.DataBind();
        //    sqlconn.Close();
        //}



        protected void Discountinput_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        protected void GV1_SelectedIndexChanged(object sender, EventArgs e)
        {

            bikeinput.Text = GV3.SelectedRow.Cells[2].Text.ToString();
            Priceinput.Text = GV3.SelectedRow.Cells[3].Text.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Personal.aspx");           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Dinput.Text.Length > 0)
            {
                ainput.Text = (Convert.ToInt32(Priceinput.Text) - Convert.ToInt32(Dinput.Text)).ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
         
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False");
                //step-1

                string query = "insert into billA values('"
                                                                + bikeinput.Text + "',"
                                                                + Priceinput.Text + ","
                                                                + Dinput.Text + ","
                                                                + ainput.Text + ")";

                //step-2
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("Added Successfully..........");
                con.Close();
             //   Response.Redirect("BILL.aspx");

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
      
        }
    }
}
