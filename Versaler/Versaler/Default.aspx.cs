using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Result.Text = "Antalet versaler är: " + Model.TextAnalyzer.GetNumberofCapitals(Text.Text).ToString();
            Text.Enabled = false;
            Button.Visible = false;
            Button1.Visible = true;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Result.Text = "";
            Text.Text = "";
            Text.Enabled = true;
            Button.Visible = true;
            
        }
    }
}