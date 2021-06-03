using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtusername.Text == "manoj" && txtpassword.Text == "aaa")
        {
            Response.Redirect("welcome.aspx");
        }
        else
        {
            Label1.Visible = true;
        }
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (txtusername.Text == "manoj" && txtpassword.Text == "aaa")
        {
            Response.Redirect("welcome.aspx");
        }
        else
        {
            Label1.Visible = true;
        }
    }
}