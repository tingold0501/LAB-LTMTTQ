using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsLab.Controller
{
    class ControllerSumANumber
    {
        public ControllerSumANumber()
        {

        }
        ~ControllerSumANumber()
        {

        }
        public void SumANumber(int n)
        {
            int sum = 0;
            for(int i = 0; i <= n; i++)
            {
                sum += i;
            }
            MessageBox.Show("Sum Of " + n + " Is " + sum);
        }
    }
}
