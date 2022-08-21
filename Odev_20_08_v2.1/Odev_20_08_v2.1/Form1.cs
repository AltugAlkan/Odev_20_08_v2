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
            InitializeComponent();
            this.label1.ForeColor= System.Drawing.Color.HotPink;

            Label lbl_isim=new Label();
            lbl_isim.AutoSize = true;     // true yaparsan cümleyi ne kadar uzatırsan o kadar büyür :D
            lbl_isim.Text = "İsim bla bla bla bla";
            this.Controls.Add(lbl_isim);
        }
    }
}
