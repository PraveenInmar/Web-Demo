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
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            poplate();
        }
        //Display
        private void poplate()
        {
            SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False");
            con.Open();
            string query = "select * from Product1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            GV1.DataSource = ds.Tables[0];
            GV1.DataBind();
            con.Close();

        }
        //Add
        protected void ADDB_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False");
                //step-1

                string query = "insert into Product1 values('"
                                                                + NAMEINPUT.Text + "',"
                                                                + QUANTITYINPUT.Text + ","
                                                                + PRICEINPUT.Text + ")";
                //step-2
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("Product Added Successfully");
                con.Close();
                poplate();
                ClearData();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        //Update
        protected void EDITB_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDINPUT.Text == "" || NAMEINPUT.Text == "" || QUANTITYINPUT.Text == "" || PRICEINPUT.Text == "")
                {
                    Response.Write("Missing Information");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False");
                    string query = "update Product1 set Name ='"
                                                + NAMEINPUT.Text + "',Quantity="
                                                + QUANTITYINPUT.Text + ",Price="
                                                + PRICEINPUT.Text + " where Id=" + IDINPUT.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Write("Product Successfully Updated");
                    con.Close();
                    poplate();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
        //Delete
        protected void DELETEB_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDINPUT.Text == "")
                {
                    Response.Write("Select The Product to Delete");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False");
                    string query = "delete from Product1 where Id=" + IDINPUT.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Write("Product Deleted Successfully");
                    con.Close();
                    poplate();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //Clear Data
        private void ClearData()
        {
            IDINPUT.Text = "";
            NAMEINPUT.Text = "";
            PRICEINPUT.Text = "";
            QUANTITYINPUT.Text = "";
        }
        //select
        protected void GV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDINPUT.Text = GV1.SelectedRow.Cells[1].Text.ToString();
            NAMEINPUT.Text = GV1.SelectedRow.Cells[2].Text.ToString();
            QUANTITYINPUT.Text = GV1.SelectedRow.Cells[3].Text.ToString();
            PRICEINPUT.Text = GV1.SelectedRow.Cells[4].Text.ToString();

        }

        protected void Seller_Click(object sender, EventArgs e)
        {
            Response.Redirect("Personal.aspx");
        }

        protected void PersonalB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Personal.aspx");
        }
    }
}