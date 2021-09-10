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

        private void ucMain_Load(object sender, EventArgs e)
        {
            this.scChild1.Panel1.Controls.Add(test.Instance);
            test.Instance.Size = scChild1.Panel1.Size;
            test.Instance.Dock = DockStyle.Fill;
            test.Instance.BringToFront();

            this.scChild2.Panel2.Controls.Add(test2.Instance);
            test2.Instance.Size = scChild2.Panel2.Size;
            test2.Instance.Dock = DockStyle.Fill;
            test2.Instance.BringToFront();
        }
    }
}
