using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int square(int x)
        {
            return x * x;
        }

        int cube (int x)
        {
            return x * x * x;
        }

        private void  clear()
        {
            TxtNumber.Clear();
            TxtTotal.Clear();
            TxtNumber.Focus();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = square(Convert.ToInt16(TxtNumber.Text)).ToString();

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnCube_Click(object sender, EventArgs e)
        {
            TxtTotal.Text = cube(Convert.ToInt16(TxtNumber.Text)).ToString();
        }
    }
}
