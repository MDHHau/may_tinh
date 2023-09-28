using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace may_tinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float n1,n2;
        string pheptinh;

        private void bt0_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "0";

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "3";
            
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + "9";
        }

        private void btCham_Click(object sender, EventArgs e)
        {
            txtMH1.Text = txtMH1.Text + ".";
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";           
            n1 = float.Parse(txtMH1.Text);
            txtMH2.Text = n1.ToString() + "+";
            txtMH1.Clear();
           
        }

        private void btB_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                n2 = n1 + float.Parse(txtMH1.Text);
                txtMH2.Text = n1.ToString() + "+" + float.Parse(txtMH1.Text) + "=";
                txtMH1.Text =  n2.ToString();
            }
            if (pheptinh == "tru")
            {
                n2 = n2 = n1 - float.Parse(txtMH1.Text);
                txtMH2.Text = n1.ToString() + "-" + float.Parse(txtMH1.Text) + "=";
                txtMH1.Text = n2.ToString();
            }
            if (pheptinh == "nhan")
            {
                n2 = n2 = n1 * float.Parse(txtMH1.Text);
                txtMH2.Text = n1.ToString() + "*" + float.Parse(txtMH1.Text) + "=";
                txtMH1.Text = n2.ToString();
            }
            if (pheptinh == "chia")
            {
                if (float.Parse(txtMH1.Text) == 0)
                {
                    
                    txtMH1.Text = "khong chia duoc";
                }
                else
                {
                    n2 = n2 = n1 / float.Parse(txtMH1.Text);
                    txtMH2.Text = n1.ToString() + "/" + float.Parse(txtMH1.Text) + "=";
                    txtMH1.Text =  n2.ToString();
                }
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            n1 = float.Parse(txtMH1.Text);
            txtMH2.Text = n1.ToString()+ "-";
            txtMH1.Clear();
            
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            txtMH2.Text = n1.ToString() + "*";
            n1 = float.Parse(txtMH1.Text);
            txtMH1.Clear();
            
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            txtMH2.Text = n1.ToString() + "/";
            n1 = float.Parse(txtMH1.Text);
            txtMH1.Clear();
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtMH1.Clear();
            txtMH2.Clear();
            
        }
    }
}
