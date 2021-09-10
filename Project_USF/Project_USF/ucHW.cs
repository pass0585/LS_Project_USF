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
    public partial class ucHW : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucHW _instance;

        public static ucHW Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucHW();
                return _instance;
            }
        }
        public ucHW()
        {
            InitializeComponent();
        }
    }
}
