﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowFormsLab.Forms;

namespace WindowFormsLab.Controller
{
    class ControllerClinic
    {
        public ControllerClinic()
        {

        }
        ~ControllerClinic()
        {

        }
        public void display()
        {
            
        }
        public void checkInformation(string name,string gender)
        {
            //if(name == "" || gender == "" )
            //{
            //    MessageBox.Show("Vui Lòng Nhập Tên Ạ !!! Pờ Lyyyy");
            //}
            //else
            //{
            //    MessageBox.Show("Tên Của Bạn Là: " + name + "Giới Tính Của Bạn Là: " + gender);
            //}

            MessageBox.Show(name + gender.ToString());
        }
    }
}
