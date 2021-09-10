using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_USF
{
    public partial class test2 : DevExpress.XtraEditors.XtraUserControl
    {
        private static test2 _instance;

        public static test2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new test2();
                return _instance;
            }
        }
        public test2()
        {
            InitializeComponent();
        }
    }
}
