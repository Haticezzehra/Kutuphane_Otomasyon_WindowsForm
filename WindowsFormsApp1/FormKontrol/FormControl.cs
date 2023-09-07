using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FormKontrol
{
  public   class FormControl
    {
        public static  bool MDIFormAcikmi(string formAdi)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == formAdi)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
