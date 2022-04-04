using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Response.Write("Hello World First");*/

            List<string> saveChat;
            if(Application["chat"] != null)
            {
                saveChat = (List<string>)Application["chat"];
                foreach (string x in saveChat)
                {
                    lsChat.Items.Add(x);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            /*int x = 10;
            int x2 = 2;
            int ansx = x + x2;

            double y = 10.5;
            double y2 = 5.5;
            double ansy = y + y2;

            string z = "Pharadorn";

            //คำสั่งในการพิมพ์ข้อความออกมาบนหน้าจอ
            Response.Write(ansy);*/


            /*if(txt_Name.Text == "Hello" && txt_Password.Text == "1234")
            {
                Response.Write("ถูกต้องน่ะครับ");
            }
            else
            {
                Response.Write("ไม่ถูกต้องน่ะครับ");
            }*/

            /*for(int i = 1; i <= 12; i++)
            {
                Response.Write(txt_Number.Text + " * " + i + " = " + (int.Parse(txt_Number.Text)*i) + "<br />");
            }*/

            /*int i = 1;
            int i2 = 1;
            while(i == 1)
            {
                Response.Write(txt_Number.Text + " * " + i2 + " = " + (int.Parse(txt_Number.Text) * i2) + "<br />");
                if(i2 == 12)
                {
                    break;
                }
                i2++;
            }*/


            /*for(int i = 1; i < 6; i++)
            {
                Response.Write("<h" + i +">Hello World</h" + i +">");
            }*/

            /*if(int.Parse(txt_Number.Text) > 0)
            {
                txt_Result.Text = "เป็นตัวเลขจำนวนเต็มบวก";
                div1.Style["background-color"] = "green";
                div1.Style["font-size"] = txt_Number.Text + "px";

            }else
            {
                txt_Result.Text = "เป็นตัวเลขจำนวนเต็มลบ";
                div1.Style["background-color"] = "red";
                div1.Style["font-size"] = "70px";
            }*/

            /* txt_Result.Text = txt_Number.Text + " " + ls_Product.SelectedItem.Text; */

            /*//Query string
            //ที่อยู่ของหน้าเว็บใหม่และตัวแปรที่จะส่งติดไปด้วย
            //ชื่อไฟล์เว็บของเรา.aspx + เครื่องหมาย ? + ตัวแปรที่ราจะใช้ส่งไป = ค่าที่เราจะส่งไป + & ตัวแปรที่ราจะใช้ส่งไป = ค่าที่เราจะส่งไป
            string url = "view.aspx?Firstname=" + txt_Number.Text + "&Lastname=" + txt_Surname.Text;
            //ทำการย้ายหน้าไปที่หน้าใหม่ของเราพร้อมค่าดังกล่าว
            Response.RedirectPermanent(url);*/

            /*//ประกาศสร้าง object cookies
            HttpCookie ckName = new HttpCookie("Name");
            HttpCookie ckLastName = new HttpCookie("LastName");

            //กำหนดค่าให้กับ cookies นั้นๆ
            ckName.Value = txt_Number.Text;
            ckLastName.Value = txt_Surname.Text;

            //เพิ่มออบเจกต์คุกกี้ลงไป
            Response.Cookies.Add(ckName);
            Response.Cookies.Add(ckLastName);

            //ย้ายหน้า
            Response.RedirectPermanent("read.aspx");*/

            //Application["x"] = "Hello";
            List<string> saveChat;
            if (Application["chat"] != null)
            {
                saveChat = (List<string>)Application["chat"];
            }
            else
            {
                saveChat = new List<string>();
            }
            saveChat.Add(txtName.Text + " : " + txtMsg.Text);
            Application["chat"] = saveChat;
            Response.RedirectPermanent("index.aspx");
        }

        protected void ls_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Result.Text = txt_Number.Text + " " + ls_Product.SelectedItem.Text;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txt_Result.Text = "คุณได้เลือกวันที่ : " + control_calendar.SelectedDate.Date.ToString();
        }
    }
}