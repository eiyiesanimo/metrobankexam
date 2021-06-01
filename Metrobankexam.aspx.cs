using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace metrobankexam
{
    public partial class Metrobankexam : System.Web.UI.Page
    {
        string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            string searchsql = "Select * from Products where productID = " + txtProductID.Text;
            SqlCommand cmd = new SqlCommand(searchsql, con);

            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
           
           if (rd.Read())
            {
                lblProductID.Text = rd.GetValue(0).ToString();
                lblProductName.Text = rd.GetValue(1).ToString();
                lblPrice.Text = rd.GetValue(2).ToString();
            }
           

        }

        protected void btnAddtoCart_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Product Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Amount");

            int total = Int32.Parse(txtQty.Text) * Int32.Parse(lblPrice.Text);
            txtTotalAmount.Text = total.ToString();

            DataRow products = dt.NewRow();
            products[0] = lblProductName.Text;
            products[1] = lblPrice.Text;
            products[2] = txtQty.Text;
            products[3] = txtTotalAmount.Text;
            dt.Rows.Add(products);
            GridOrder.DataSource = dt;
            GridOrder.DataBind();

        }

        protected void SaveTransaction_Click(object sender, EventArgs e)
        {
            int change = Int32.Parse(txtCash.Text) - Int32.Parse(txtTotalAmount.Text);
            txtChange.Text = change.ToString();

            DataTable dt = new DataTable();

            dt.Columns.Add("Product Name");
            dt.Columns.Add("Price");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Amount");

            int total = Int32.Parse(txtQty.Text) * Int32.Parse(lblPrice.Text);
            txtTotalAmount.Text = total.ToString();

            DataRow products = dt.NewRow();
            products[0] = lblProductName.Text;
            products[1] = lblPrice.Text;
            products[2] = txtQty.Text;
            products[3] = txtTotalAmount.Text;
            dt.Rows.Add(products);
            GridOrder.DataSource = dt;
            GridOrder.DataBind();

            txtSuccess.Text = "Transaction has been successfully saved!";
        }
    }
}