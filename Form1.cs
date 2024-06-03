using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_gptb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtso1_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void btngpt_Click(object sender, EventArgs e)
        {
            Double a, b, x;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            if(a!=0)
            {
                x = -b / a;
                lblketqua.Text = "Nghiệm của phương trình là x= " + x.ToString();

            }
            else
            {
                if(b!=0)
                {
                    lblketqua.Text = "Phương rình vô nghiệm";

                }
                else
                {
                    lblketqua.Text = "Phương trình nghiệm đúng với mọi x";
                }
                    
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtA.Text = trackBar1.Value.ToString();
        }
    }
    
}
