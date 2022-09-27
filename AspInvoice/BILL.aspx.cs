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
    public partial class BILL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            featchdata();
           
        }
       


        public void featchdata()
        {

            string conn = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconn = new SqlConnection(conn);
            sqlconn.Open();
            string query = "select Name,Id,Address from Web1 ";
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            DDL1.DataSource = ds;
            DDL1.DataValueField = "Name";
           // DDL1.DataValueField = "Address";
            DDL1.DataTextField = "Id";
            DDL1.DataBind();
            DDL1.Items.Insert(0, "....Select....");
            sqlconn.Close();

           }

        protected void DDL1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
            string text = DDL1.SelectedItem.Text;
            string name = DDL1.SelectedValue;
            Nameinput.Text = String.Format("{0}", name);
         //   string add = DDL1.SelectedValue;
          //  Addressinput.Text = String.Format("{0}", add);
        }
    }
}