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
    public partial class Personal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            poplate();
        }
        private void poplate()
        {
            SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False");
            con.Open();
            string query = "select * from Web1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PersonalDGV.DataSource = ds.Tables[0];
            PersonalDGV.DataBind();
            con.Close();

        }
        //Add
        protected void ADDB_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False");
                //step-1

                string query = "insert into Web1 values('"
                                                                + NAMEINPUT.Text + "',"
                                                                + Ageinput.Text + ",'"
                                                                + Addressinput.Text + "')";

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
                if (IDINPUT.Text == "" || NAMEINPUT.Text == "" || Ageinput.Text == "" || Addressinput.Text == "")
                {
                    Response.Write("Missing Information");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=IN-WIN-PKUMAR\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False");
                    string query = "update Web1 set Name ='"
                                                + NAMEINPUT.Text + "',Age="
                                                + Ageinput.Text + ",Address='"
                                                + Addressinput.Text + "' where Id=" + IDINPUT.Text + ";";
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
                    string query = "delete from Web1 where Id=" + IDINPUT.Text + "";
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
            Ageinput.Text = "";
            Addressinput.Text = "";
        }

        protected void Product_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }

        protected void GV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDINPUT.Text = PersonalDGV.SelectedRow.Cells[1].Text.ToString();
            NAMEINPUT.Text = PersonalDGV.SelectedRow.Cells[2].Text.ToString();
            Ageinput.Text = PersonalDGV.SelectedRow.Cells[3].Text.ToString();
            Addressinput.Text = PersonalDGV.SelectedRow.Cells[4].Text.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Shoping.aspx");
        }
    }
}