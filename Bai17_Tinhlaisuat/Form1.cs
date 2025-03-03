using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai17_Tinhlaisuat
{
    public partial class Form1 : Form
    {
        private double tienlai;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            double sotien = long.Parse(txtVon.Text);
            double Ls = double.Parse(txtLaiSuat.Text.Replace("%", ""));
            int NAM = Convert.ToInt32(txtNam.Text);
            double tienlai = 0;

            lstKQ.Items.Clear();    

            for (int i = 1; i <= NAM; i++) 
            {
                tienlai = sotien * Ls;
                lstKQ.Items.Add("Năm " + i + ":Vốn=" + sotien + " - lãi suất:" + tienlai);

                sotien += tienlai;
            }

        }


        private void form1_load (object sender, EventArgs e)
        {
            txtVon.Text = "10000000";
            txtLaiSuat.Text = "7,5%";
            txtNam.Text = "10%";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double sotien = double.Parse(txtVon.Text);
            double Ls = double.Parse(txtLaiSuat.Text.Replace("%", ""));
            int NAM = Convert.ToInt32(txtNam.Text);
            double tienlai = 0;

            lstKQ.Items.Clear();

            for (int i = 1; i <= NAM; i++)
            {
                tienlai = sotien * Ls;
                lstKQ.Items.Add("Năm " + i + ":Vốn=" + string.Format("{0:N0}", sotien) + "- tiền lãi:" + string.Format("{0:N2}"), tienlai);

                sotien += tienlai;
            }
    }

    }
}
