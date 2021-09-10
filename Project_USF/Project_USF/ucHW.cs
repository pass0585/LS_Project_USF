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
    public partial class ucWH : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucWH _instance;

        public static ucWH Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucWH();
                return _instance;
            }
        }
        public ucWH()
        {
            InitializeComponent();
        }
    }
}
