using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace caching_example
{
    public partial class grid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetStudentByBranch("all");
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStudentByBranch(DropDownList1.SelectedItem.Value);
        }

        private void GetStudentByBranch(string branch)
        {
            SqlConnection con = new SqlConnection("Data Source=suypc218;Initial Catalog=advanced;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("spGetByBranch", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
           
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@branch";
            param.Value = branch;
            da.SelectCommand.Parameters.Add(param);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}