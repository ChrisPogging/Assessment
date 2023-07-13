using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assessment
{
    public partial class Question1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Fruits and Veggies");

                gvFnV.DataSource = dt;
                gvFnV.DataBind();
            }
        }

        protected void btnPopulate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Fruits and Veggies");

            List<string> fnv = new List<string>();
            fnv = File.ReadAllLines(Server.MapPath("Fruits and Veggies.txt")).Select(x => x.Split('\n')[0]).ToList();
            foreach (var fav in fnv)
            {
                dt.Rows.Add(fav);
            }

            gvFnV.DataSource = dt;
            gvFnV.DataBind();
        }
    }
}