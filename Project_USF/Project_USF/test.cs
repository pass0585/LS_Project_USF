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
    public partial class test : DevExpress.XtraEditors.XtraUserControl
    {
        private static test _instance;

        public static test Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new test();
                return _instance;
            }
        }

        public test()
        {
            InitializeComponent();
        }
    }
}
