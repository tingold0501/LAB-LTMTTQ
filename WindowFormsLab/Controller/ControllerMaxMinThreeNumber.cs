using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsLab.Controller
{
    class ControllerMaxMinThreeNumber
    {
        public ControllerMaxMinThreeNumber()
        {

        }
        ~ControllerMaxMinThreeNumber()
        {

        }
        public void MaxMinThreeNumber(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                MessageBox.Show("Number Max Is : " + a);
                if (b > c)
                {
                    MessageBox.Show("Number Min Is : " + c);
                }
                return;
            }
            if (b > a && b > c)
            {
                MessageBox.Show("Number Max Is : " + b);
                if (c > a)
                {
                    MessageBox.Show("Number Min Is : " + a);
                }
                return;
            }
            if (c > a && c > b)
            {
                MessageBox.Show("Number Max Is : " + c);
                if (a > b)
                {
                    MessageBox.Show("Number Min Is : " + b);

                }
                return;
            }

        }
    }
}
