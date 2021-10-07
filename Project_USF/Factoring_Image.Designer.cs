
namespace Project_USF
{
    partial class Factoring_Image
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factoring_Image));
            this.Show_Button = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Show_Button
            // 
            this.Show_Button.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions1.EnableTransparency = true;
            windowsUIButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions1.Image")));
            this.Show_Button.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("SHOW", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.Show_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Show_Button.Location = new System.Drawing.Point(0, 0);
            this.Show_Button.Name = "Show_Button";
            this.Show_Button.Size = new System.Drawing.Size(144, 131);
            this.Show_Button.TabIndex = 2;
            this.Show_Button.Text = "windowsUIButtonPanel1";
            this.Show_Button.Click += new System.EventHandler(this.Show_Button_Click);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.Show_Button);
            this.sidePanel1.Location = new System.Drawing.Point(3, 19);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(144, 131);
            this.sidePanel1.TabIndex = 3;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // Factoring_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Name = "Factoring_Image";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Size = new System.Drawing.Size(868, 486);
            this.Load += new System.EventHandler(this.Factoring_Image_Load);
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel Show_Button;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
    }
}
