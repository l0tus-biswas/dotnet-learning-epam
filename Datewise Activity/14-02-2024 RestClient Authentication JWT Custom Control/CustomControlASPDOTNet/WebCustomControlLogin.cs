using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControlASPDOTNet
{
    [ToolboxData("<{0}:WebCustomControlLogin runat=server></{0}:WebCustomControlLogin>")]
    public class WebCustomControlLogin : CompositeControl
    {
        Label lblusername;
        Label lblpassword;
        TextBox textBox1;
        TextBox textBox2;

        Button button1;
        LiteralControl lt1;
        Label label1;

        protected override void CreateChildControls()
        {
            lblusername = new Label();
            lblusername.Text = "Enter Username";
            lblusername.Width = Unit.Pixel(130);

            lblpassword = new Label();
            lblpassword.Text = "Enter Password";
            lblpassword.Width = Unit.Pixel(130);

            textBox1 = new TextBox();
            textBox1.ID = "txtBox1";
            textBox1.Width = Unit.Pixel(150);

            textBox2 = new TextBox();
            textBox2.ID = "txtBox2";
            textBox2.Width = Unit.Pixel(150);

            button1 = new Button();
            button1.ID = "btnSubmit";
            button1.Text = "Submit";
            button1.Width = Unit.Pixel(100);
            button1.Click += new EventHandler(btnSubmit_Click);


            lt1 = new LiteralControl("<br/>");

            label1  =new Label();

            this.Controls.Add(lblusername);
            this.Controls.Add(textBox1);
            this.Controls.Add(lt1);
            this.Controls.Add(lblpassword);
            this.Controls.Add(textBox2);
            this.Controls.Add(lt1);
            this.Controls.Add(button1);
            this.Controls.Add(lt1);
            this.Controls.Add(lt1);
            this.Controls.Add(label1);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            lblusername.RenderControl(writer);
            textBox1.RenderControl(writer);
            lt1.RenderControl(writer);
            lblpassword.RenderControl(writer);
            textBox2.RenderControl(writer);
            lt1.RenderControl(writer);
            button1.RenderControl(writer);
            lt1.RenderControl(writer);
            lt1.RenderControl(writer);
            label1.RenderControl(writer);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "username" && textBox2.Text == "password")
            {
                label1.Text = "Welcome! Login Error";
                label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label1.Text = "Wrong Username or Password";
                label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
