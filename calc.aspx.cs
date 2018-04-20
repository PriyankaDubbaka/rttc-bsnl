using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("http://www.google.com");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a, b, c;
        a = Int32.Parse(TextBox1.Text);
        b = Int32.Parse(TextBox2.Text);
        c = a + b;
        TextBox3.Text = c.ToString();
       
        Class1.
        
    }
}