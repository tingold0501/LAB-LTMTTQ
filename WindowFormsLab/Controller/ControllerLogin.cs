using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFormsLab.Forms;
using System.Windows.Forms;

namespace WindowFormsLab.Controller
{
    class ControllerLogin
    {

       public ControllerLogin()
        {

        }
        ~ControllerLogin()
        {

        }


        public void InputTextBox(string name , string address)
        {
            if(name == "" || address =="")
            {
                MessageBox.Show("Hãy Nhập Đầy Đủ!! Pờ lyyyy");
            }
            else
            {
                MessageBox.Show("Tên Của Bạn Là : " + name + "Và Địa Chỉ Của Bạn Là : " + address);
            }
            
        }
        public void ChooesItemsListBox(string item)
        {
            MessageBox.Show("Bạn Đã Chọn : " + item);
        }

    }
}
