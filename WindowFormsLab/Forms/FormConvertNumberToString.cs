using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowFormsLab.Controller;

namespace WindowFormsLab.Forms
{
    public partial class FormConvertNumberToString : Form
    {
        public FormConvertNumberToString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControllerConvertNumberToString controller = new ControllerConvertNumberToString();
            int n = int.Parse(tbNumberN.Text);
            controller.ConvertNumberToString(n);
        }

        private void tbNumberN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
