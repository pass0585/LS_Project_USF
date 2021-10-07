using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_USF
{
    public partial class Factoring_Video : DevExpress.XtraEditors.XtraUserControl
    {
        public static Factoring_Video _instance;

        public static Factoring_Video Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Factoring_Video();
                return _instance;
            }
        }

        public Factoring_Video()
        {
            InitializeComponent();
            wmpVideo.uiMode = "none";
        }

        public void Button_Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            wmpVideo.Ctlcontrols.pause();
            Factoring_Image.Instance.Visible = true;
           // this.Parent.Controls.Add(Factoring_Image.Instance);

        }

        public void play()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            //var iconPath = Path.Combine(outPutDirectory, "../../Resources\\Video\\사과Sorting.mp4");
            var iconPath = Path.Combine(outPutDirectory, "../../Resources\\Video\\mylove_movie.mp4");
            string videoPath = new Uri(iconPath).LocalPath;

            wmpVideo.URL = videoPath;
            wmpVideo.Ctlcontrols.play();
        }
    }
}
