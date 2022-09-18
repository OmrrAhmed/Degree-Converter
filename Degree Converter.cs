using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegreeConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            

            txtDDX.Text = converter.ConvertDegree(int.Parse(txtLongD.Text), int.Parse(txtLongM.Text), float.Parse(txtLongS.Text)).ToString();
            txtDDY.Text = converter.ConvertDegree(int.Parse(txtLatD.Text), int.Parse(txtLatM.Text), float.Parse(txtLatS.Text)).ToString();
        }
    }
}

class converter
{
    public static double ConvertDegree(int degree, int min, float sec)
    {


        return degree + min / 60 + sec / 3600;
    }
}
