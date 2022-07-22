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

namespace WindowFormsLab
{
    public partial class FormMaxMinTwoNumber : Form
    {
        public FormMaxMinTwoNumber()
        {
            InitializeComponent();
        }

      

        private void btEnter_Click(object sender, EventArgs e)
        {
            ControlllerMaxMinTwoNumber controlller = new ControlllerMaxMinTwoNumber();
            int a = int.Parse(tbNumberA.Text);
            int b = int.Parse(tbNumberB.Text);
            controlller.MaxMin(a,b);
        }
    }
}
