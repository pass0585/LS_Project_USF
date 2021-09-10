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
    public partial class ucINSP : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucINSP _instance;

        public static ucINSP Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucINSP();
                return _instance;
            }
        }
        public ucINSP()
        {
            InitializeComponent();
        }
    }
}
