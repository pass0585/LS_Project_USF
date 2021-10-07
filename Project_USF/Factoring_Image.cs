using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class Factoring_Image : DevExpress.XtraEditors.XtraUserControl
    {
        private static Factoring_Image _instance;

        public static Factoring_Image Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Factoring_Image();
                return _instance;
            }
        }

        public Factoring_Image()
        {
            InitializeComponent();
        }

        private void Factoring_Image_Load(object sender, EventArgs e)
        {
            ImageSlider mySlider = new ImageSlider();
            mySlider.Parent = this;
            mySlider.Dock = DockStyle.Fill;
            //Populate ImageSlider with images

            mySlider.Images.Add(Image.FromFile(@"../../Resources\Image\로봇.png"));
            mySlider.Images.Add(Image.FromFile(@"../../Resources\Image\반도체.png"));
            mySlider.Images.Add(Image.FromFile(@"../../Resources\Image\볼트.png"));
            mySlider.Images.Add(Image.FromFile(@"../../Resources\Image\자동차.png"));

            mySlider.AnimationTime = 1200;

            mySlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleCenter;


            ////////////////// 이미지 타이틀 띄워줄 2가지방법 
            ///                       1. 배열에 경로 저장하고 배열에 값을 짤라서 읽어오는법 (currentimage index)
            ///                       2. currentimage의 property로 접근할 수 있는 방법이 있나 ?)
            /// 
            //Image_Title.Text = 
         }



        private void Show_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Factoring_Video.Instance.Visible = true;
            Factoring_Video.Instance.play();
            this.Parent.Controls.Add(Factoring_Video.Instance);
            Factoring_Video.Instance.Size = this.Parent.Size;
            Factoring_Video.Instance.Dock = DockStyle.Fill;
            Factoring_Video.Instance.BringToFront();
        }
    }
}
