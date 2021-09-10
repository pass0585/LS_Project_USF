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
    public partial class ucMain : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucMain _instance;

        public static ucMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMain();
                return _instance;
            }
        }

        public ucMain()
        {
            InitializeComponent();
        }
    }
}
