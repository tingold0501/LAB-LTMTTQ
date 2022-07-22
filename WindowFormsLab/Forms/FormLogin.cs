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
    public partial class FormLogin : Form
    {
        ControllerLogin controller = new ControllerLogin();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string address = tbAddress.Text;
            controller.InputTextBox(name, address);
        }

        private void radioButton(object sender, EventArgs e)
        {
            if(rdioFemale.Checked == true)
            {
                MessageBox.Show(rdioFemale.Text);
            }
            else
            {
                MessageBox.Show(rdoMale.Text);
            }
        }

        private void lBoxDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = lBoxDetails.SelectedItem.ToString();  
            controller.ChooesItemsListBox(item);
        }

        private void checkButton(object sender, EventArgs e)
        {
            if(cbC.Checked == true)
            {
                cbASP.Checked = false;
                MessageBox.Show(cbC.Text);
            }
            else if(cbASP.Checked == true)
            {
                cbC.Checked = false;
                MessageBox.Show(cbASP.Text);
            }
        }

       
    }
}
