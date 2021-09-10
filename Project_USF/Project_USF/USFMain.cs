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
    public partial class USFMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public USFMain()
        {
            InitializeComponent();
        }
        // 메인 탭
        private void aceMain_Click(object sender, EventArgs e)
        {
            if(!container.Controls.Contains(ucMain.Instance))
            {
                container.Controls.Add(ucMain.Instance);
                ucMain.Instance.Dock = DockStyle.Fill;
                ucMain.Instance.BringToFront();
            }
            ucMain.Instance.BringToFront();
        }
        // 검사 탭
        private void aceInsp_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucINSP.Instance))
            {
                container.Controls.Add(ucINSP.Instance);
                ucINSP.Instance.Dock = DockStyle.Fill;
                ucINSP.Instance.BringToFront();
            }
            ucINSP.Instance.BringToFront();
        }
        // 창고 탭
        private void aceWH_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucWH.Instance))
            {
                container.Controls.Add(ucWH.Instance);
                ucWH.Instance.Dock = DockStyle.Fill;
                ucWH.Instance.BringToFront();
            }
            ucWH.Instance.BringToFront();
        }

        private void USFMain_Load(object sender, EventArgs e)
        {
            // 시작시 메인화면 띄우기
            container.Controls.Add(ucINSP.Instance);
            ucINSP.Instance.Dock = DockStyle.Fill;
            ucINSP.Instance.BringToFront();
        }
    }
}