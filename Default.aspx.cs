using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary2;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NorthwindEntities ctx = new NorthwindEntities();
        var qry = from c in ctx.Customers
                  where c.Country == "UK"
                  select new { c.CompanyName, c.ContactName, c.Address };

        GridView1.DataSource = qry.ToList();
        GridView1.DataBind();

    }
}