using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo
{
    public partial class read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            //ไปดึงคุกกี้มาจากระบบ
            HttpCookie ckName = Request.Cookies["Name"];
            HttpCookie ckLastName = Request.Cookies["LastName"];

            //มีค่าอยู่หรือไม่
            if((ckName.Value != null) && (ckLastName.Value != null))
            {
                showName.Text = ckName.Value;
                showLastname.Text = ckLastName.Value;
            }
        }
    }
}