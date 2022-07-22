using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsLab.Controller
{
    class ControllerConvertNumberToString
    {
        public ControllerConvertNumberToString()
        {

        }
        ~ControllerConvertNumberToString()
        {

        }

        public void ConvertNumberToString(int n)
        {
            string value = null;
            switch (n)
            {
                case 0:
                    value = "Khong";
                    MessageBox.Show(value);
                    break;
                case 1:
                    value = "Mot";
                    MessageBox.Show(value);
                    break;
                case 2:
                    value = "Hai";
                    MessageBox.Show(value);
                    break;
                case 3:
                    value = "Ba";
                    MessageBox.Show(value);
                    break;
                case 4:
                    value = "Bon";
                    MessageBox.Show(value);
                    break;
                case 5:
                    value = "Nam";
                    MessageBox.Show(value);
                    break;
                case 6:
                    value = "Sau";
                    MessageBox.Show(value);
                    break;
                case 7:
                    value = "Bay";
                    MessageBox.Show(value);
                    break;
                case 8:
                    value = "Tam";
                    MessageBox.Show(value);
                    break;
                case 9:
                    value = "Chin";
                    MessageBox.Show(value);
                    break;
                default:
                    MessageBox.Show("So Khong Ho Le!!!");
                    break;


            }
        }
    }
}
