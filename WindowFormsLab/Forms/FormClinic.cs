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
    public partial class FormClinic : Form
    {
        ControllerClinic controller = new ControllerClinic();   
        public FormClinic()
        {
            InitializeComponent();
        }

        private void btnCheckName_Click(object sender, EventArgs e)
        {
            string name = tbFullName.Text;
            string gender = lbGender.SelectedItem.ToString();
            controller.checkInformation(name, gender);
        }
    }
}
