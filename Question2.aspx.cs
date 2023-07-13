using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Assessment
{
    public partial class Question2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();

                gvEmployees.DataSource = dt;
                gvEmployees.DataBind();
            }
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand("SELECT e.Name, d.Designation, e.Age FROM Employee_Profiles e, Departments d WHERE Age IN ((SELECT MIN (Age) FROM Employee_Profiles), (SELECT MAX (Age) FROM Employee_Profiles)) AND e.id = d.empId", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gvEmployees.DataSource = dt;
            gvEmployees.DataBind();
            cmd.Dispose();

            
        }
    }
}