﻿using DevExpress.XtraEditors;
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

        private void aceWH_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucHW.Instance))
            {
                container.Controls.Add(ucHW.Instance);
                ucHW.Instance.Dock = DockStyle.Fill;
                ucHW.Instance.BringToFront();
            }
            ucHW.Instance.BringToFront();
        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }
    }
}