
namespace Project_USF
{
    partial class ucMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scParent = new DevExpress.XtraEditors.SplitContainerControl();
            this.scChild1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.scChild2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.scParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scParent.Panel1)).BeginInit();
            this.scParent.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scParent.Panel2)).BeginInit();
            this.scParent.Panel2.SuspendLayout();
            this.scParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChild1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scChild1.Panel1)).BeginInit();
            this.scChild1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChild1.Panel2)).BeginInit();
            this.scChild1.Panel2.SuspendLayout();
            this.scChild1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChild2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scChild2.Panel1)).BeginInit();
            this.scChild2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChild2.Panel2)).BeginInit();
            this.scChild2.Panel2.SuspendLayout();
            this.scChild2.SuspendLayout();
            this.SuspendLayout();
            // 
            // scParent
            // 
            this.scParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scParent.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.scParent.Location = new System.Drawing.Point(0, 0);
            this.scParent.Margin = new System.Windows.Forms.Padding(0);
            this.scParent.Name = "scParent";
            // 
            // scParent.scParent_Panel1
            // 
            this.scParent.Panel1.Controls.Add(this.scChild1);
            this.scParent.Panel1.Text = "Panel1";
            // 
            // scParent.scParent_Panel2
            // 
            this.scParent.Panel2.Controls.Add(this.scChild2);
            this.scParent.Panel2.Text = "Panel2";
            this.scParent.Size = new System.Drawing.Size(704, 459);
            this.scParent.SplitterPosition = 346;
            this.scParent.TabIndex = 0;
            // 
            // scChild1
            // 
            this.scChild1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scChild1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.scChild1.Horizontal = false;
            this.scChild1.Location = new System.Drawing.Point(0, 0);
            this.scChild1.Margin = new System.Windows.Forms.Padding(0);
            this.scChild1.Name = "scChild1";
            // 
            // scChild1.scChild1_Panel1
            // 
            this.scChild1.Panel1.Controls.Add(this.labelControl1);
            this.scChild1.Panel1.Text = "Panel1";
            // 
            // scChild1.scChild1_Panel2
            // 
            this.scChild1.Panel2.Controls.Add(this.labelControl2);
            this.scChild1.Panel2.Text = "Panel2";
            this.scChild1.Size = new System.Drawing.Size(353, 459);
            this.scChild1.SplitterPosition = 217;
            this.scChild1.TabIndex = 0;
            // 
            // scChild2
            // 
            this.scChild2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scChild2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.scChild2.Horizontal = false;
            this.scChild2.Location = new System.Drawing.Point(0, 0);
            this.scChild2.Margin = new System.Windows.Forms.Padding(0);
            this.scChild2.Name = "scChild2";
            // 
            // scChild2.scChild2_Panel1
            // 
            this.scChild2.Panel1.Controls.Add(this.labelControl3);
            this.scChild2.Panel1.Text = "Panel1";
            // 
            // scChild2.scChild2_Panel2
            // 
            this.scChild2.Panel2.Controls.Add(this.labelControl4);
            this.scChild2.Panel2.Text = "Panel2";
            this.scChild2.Size = new System.Drawing.Size(348, 459);
            this.scChild2.SplitterPosition = 222;
            this.scChild2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(131, 89);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(133, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "scChild1.scChild1_Panel1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(131, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "scChild1.scChild1_Panel2";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(128, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "scChild2.scChild2_Panel1";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(128, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(133, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "scChild2.scChild2_Panel2";
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scParent);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(704, 459);
            ((System.ComponentModel.ISupportInitialize)(this.scParent.Panel1)).EndInit();
            this.scParent.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scParent.Panel2)).EndInit();
            this.scParent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scParent)).EndInit();
            this.scParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scChild1.Panel1)).EndInit();
            this.scChild1.Panel1.ResumeLayout(false);
            this.scChild1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChild1.Panel2)).EndInit();
            this.scChild1.Panel2.ResumeLayout(false);
            this.scChild1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChild1)).EndInit();
            this.scChild1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scChild2.Panel1)).EndInit();
            this.scChild2.Panel1.ResumeLayout(false);
            this.scChild2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChild2.Panel2)).EndInit();
            this.scChild2.Panel2.ResumeLayout(false);
            this.scChild2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scChild2)).EndInit();
            this.scChild2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl scParent;
        private DevExpress.XtraEditors.SplitContainerControl scChild1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SplitContainerControl scChild2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
