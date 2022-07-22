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
    public partial class FormMaxMinThreeNumber : Form
    {
        public FormMaxMinThreeNumber()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            ControllerMaxMinThreeNumber controller = new ControllerMaxMinThreeNumber();
            int a = int.Parse(tbNumberA.Text);
            int b = int.Parse(tbNumberB.Text);
            int c = int.Parse(tbNumberC.Text);
            controller.MaxMinThreeNumber(a,b,c);
        }
    }
}
