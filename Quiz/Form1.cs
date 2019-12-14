using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_SHOW_Click(object sender, EventArgs e)
        {
            string ans = "";
            double root1 = 0;
            double root2 = 0;
            double b = 0;
            double a = 0;
            double c = 0;
            double identifier = 0;

            int n;

            Math1 getstring = new Math1();
            //string ohamad = "a*x^2+b*x+c=0";
            string Mohamad = TB_IS.Text;
            string aa = Mohamad.Substring(0, 1);
            if (aa == "-")
            {
                a = Convert.ToDouble(Mohamad.Substring(0, 2));
                n = 10;
                
            }
           else {
                a = Convert.ToDouble(aa);
                n = 9;


            }
            b = Convert.ToDouble(getstring.GetStringBetween(Mohamad, "*x^2", "*x"));
            c = Convert.ToDouble(getstring.GetStringBetween(Mohamad, Mohamad.Substring(0, n), "=0"));

            identifier = b * b - (4 * a * c);

            if (identifier > 0)
            {
                root1 = -b + (Math.Sqrt(identifier) / (2 * a));
                root2 = (-b - (Math.Sqrt(identifier) / (2 * a)));
                string r1 = Convert.ToString(root1);
                string r2 = Convert.ToString(root2);
                ans = "x =" + r1 + "x = " + r2;
                LB_RESULT.Text = ans.ToString();
            }

            if (identifier < 0)
            {
                double Real = (-b / (2 * a));
                double Complex = ((Math.Sqrt((identifier * (-1.00))) / (2 * a)));
                string SReal = Convert.ToString(Real);
                string SComplex = Convert.ToString(Complex);
                ans = "x = " + SReal + "+/-" + SComplex + "i";
                LB_RESULT.Text = ans.ToString();
            }

            if (identifier == 0)
            {
                root1 = (-b / (2 * a));
                string Root = Convert.ToString(root1);
                ans = "x : " + Root;
                LB_RESULT.Text = ans.ToString();
            }

        }

    }
}

