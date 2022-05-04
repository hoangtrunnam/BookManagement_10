using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txtNum1.Text);
            var num2 = Convert.ToInt32(txtNum2.Text);
            var result = num1 + num2;
            txtResult.Text = result.ToString();
        }
    }
}
