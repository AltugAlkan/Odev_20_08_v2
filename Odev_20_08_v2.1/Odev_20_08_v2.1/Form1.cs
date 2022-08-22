using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_20_08_v2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //label ve textbox aynı sınıftan (control sınıfından) kalıtım yapar.
            // O yüzden farklı sınıflar olmasına rağmen farklı değerler atanabilir.
            // Her oluşturduğumuz nesen o sınıfın türünde olur. (ex.1 ve ex.2)

            InitializeComponent();
            this.label1.ForeColor= System.Drawing.Color.HotPink;

            Label lbl_isim=new Label();
            lbl_isim.AutoSize = true;     // true yaparsan cümleyi ne kadar uzatırsan o kadar büyür :D
            lbl_isim.Text = "İsim bla bla bla bla";
            this.Controls.Add(lbl_isim);

            Label lbl_soyisim =new Label(); // Ex.1
            lbl_soyisim.Text = "Soyisim:";
            lbl_soyisim.Location = new Point(250, 57);
            this.Controls.Add(lbl_soyisim);

            TextBox tb_isim = new TextBox(); // Ex.2
            tb_isim.Location = new Point(300, 30);
            this.Controls.Add(tb_isim);
        }
    }
}
