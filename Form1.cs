using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_tinhcvdthinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double dientich = bankinh * bankinh * Math.PI;
            lblkq.Text = "-Diện tích " + Convert.ToString(dientich);
            lblkq.Text = dientich.ToString();
        }

        private void btndientich_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            double chuvi = bankinh * 2 * Math.PI;
            lblkq.Text = "-Chu vi " + Convert.ToString(chuvi);
            lblkq.Text = chuvi.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnloai1_Click(object sender, EventArgs e)

        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            if (rdbdientich.Checked)
            {
                double dientich = bankinh * bankinh * Math.PI;
                string thongbao = "-Diện tích " + Convert.ToString(dientich);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdbchuvi.Checked)
            {
                double chuvi = bankinh * 2 * Math.PI;
                string thongbao = "-Chu vi " + Convert.ToString(chuvi);
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnloai2_Click(object sender, EventArgs e)
        {
            double bankinh = Convert.ToDouble(txtbankinh.Text);
            string thongbao = "";
            if (cbdientich.Checked)
            {
                double dientich = bankinh * bankinh * Math.PI;
                thongbao = thongbao + "-Diện tích " + Convert.ToString(dientich) + Environment.NewLine;
            }
            if (cbchuvi.Checked)
            {
                double chuvi = bankinh * 2 * Math.PI;
                thongbao = thongbao + "-Chu vi " + Convert.ToString(chuvi) + Environment.NewLine;
            }
            if (thongbao.Length > 0)
            {
                MessageBox.Show(thongbao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

