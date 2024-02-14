using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Markup;

namespace NotepadCustomControl
{
    [ToolboxData("<{0}:Notepad runat=server></{0}:Notepad>")]
    public class Notepad : CompositeControl
    {

        Label lblAppName;
        TextBox textBox1;

        Button clearBtn;
        Button pasteBtn;
        Button foreClrBlueBtn;
        Button foreClrBlackBtn;
        Button increaseFontBtn;

        LiteralControl lt1;
        Label label1;

        protected override void CreateChildControls()
        {
            lblAppName = new Label();
            lblAppName.Text = "My Custom Notepad";
            lblAppName.Width = Unit.Pixel(150);

            lt1 = new LiteralControl("<br/>");

            textBox1 = new TextBox();
            textBox1.ID = "textBox1";
            textBox1.Height = Unit.Pixel(100);
            textBox1.Width = Unit.Pixel(100);
            lt1 = new LiteralControl("<br/>");

            clearBtn = new Button();
            clearBtn.ID = "btnClear";
            clearBtn.Text = "Clear";
            clearBtn.Width = Unit.Pixel(100);
            clearBtn.Click += new EventHandler(btnClear_Click);

            lt1 = new LiteralControl(" ");

            pasteBtn = new Button();
            pasteBtn.ID = "btnPaste";
            pasteBtn.Text = "Paste";
            pasteBtn.Width = Unit.Pixel(100);
            pasteBtn.Click += new EventHandler(btnPaste_Click);

            lt1 = new LiteralControl(" ");

            foreClrBlueBtn = new Button();
            foreClrBlueBtn.ID = "btnColorToBlue";
            foreClrBlueBtn.Text = "Change Text Blue";
            foreClrBlueBtn.Width = Unit.Pixel(100);
            foreClrBlueBtn.Click += new EventHandler(btn_foreClrBlueBtn_Click);

            lt1 = new LiteralControl(" ");

            foreClrBlackBtn = new Button();
            foreClrBlackBtn.ID = "btnColorToBlack";
            foreClrBlackBtn.Text = "Change Text Black";
            foreClrBlackBtn.Width = Unit.Pixel(100);
            foreClrBlackBtn.Click += new EventHandler(btn_foreClrBlackBtn_Click);


            lt1 = new LiteralControl("<br/>");

            increaseFontBtn = new Button();
            increaseFontBtn.ID = "btnIncreaseFont";
            increaseFontBtn.Text = "Increase Font Size";
            increaseFontBtn.Width = Unit.Pixel(100);
            increaseFontBtn.Click += new EventHandler(btn_increaseFontBtn_Click);

            

            label1 = new Label();
            this.Controls.Add(lblAppName);
            this.Controls.Add(lt1);
            this.Controls.Add(textBox1);
            this.Controls.Add(clearBtn);
            this.Controls.Add(lt1);
            this.Controls.Add(pasteBtn);
            this.Controls.Add(lt1);
            this.Controls.Add(foreClrBlueBtn);
            this.Controls.Add(lt1);
            this.Controls.Add(foreClrBlackBtn);
            this.Controls.Add(increaseFontBtn);
            this.Controls.Add(label1);


        }

        private void btn_increaseFontBtn_Click(object sender, EventArgs e)
        {
            textBox1.Font.Size = +2;
        }

        protected override void Render(HtmlTextWriter writer)
        {
            lblAppName.RenderControl(writer);
            lt1.RenderControl(writer);
            textBox1.RenderControl(writer);
            clearBtn.RenderControl(writer);
            lt1.RenderControl(writer);
            pasteBtn.RenderControl(writer);
            lt1.RenderControl(writer);
            foreClrBlueBtn.RenderControl(writer);
            lt1.RenderControl(writer);
            foreClrBlackBtn.RenderControl(writer);
            increaseFontBtn.RenderControl(writer);
            label1.RenderControl(writer);
        }

        private void btn_foreClrBlueBtn_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Blue;
            label1.Text = "Changed to Blue Success!";
        }

        private void btn_foreClrBlackBtn_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Black;
            label1.Text = "Changed to Black Success!";
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            string clipboardText = HttpContext.Current.Request.Form["clipboardData"];
            textBox1.Text += clipboardText;
            label1.Text = "Pasted Success!";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "Clear All Success!";
        }
    }
}
