using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsLab.Controller
{
    class ControlllerMaxMinTwoNumber
    {
        public ControlllerMaxMinTwoNumber()
        {

        }
        ~ControlllerMaxMinTwoNumber()
        {

        }
        public void MaxMin(int a, int b)
        {
            if(a > b)
            {
                
                MessageBox.Show("Number Max Is :" + a + " Number Min Is : " + b);
            }
            if(b > a)
            {
                MessageBox.Show("Number Max Is :" + b + " Number Min Is :" + a);
            }
        }
    }
}
