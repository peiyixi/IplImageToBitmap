using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IplImageToBitmap;
using IplImageToBitmap.cv;
namespace translationDemo
{
    /// <summary>
    /// 用于测试的C#窗口
    /// </summary>
    public partial class TestForm : Form
    {
        [DllImport("OpenCVtest.dll")]
        public static extern IntPtr test(string fileName);//OpenCV测试程序
        public TestForm()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
             //    pp = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(MIplImage)));
                IntPtr pp = test(open.FileName);
                Bitmap img = Ctransform.IplImageToBitmap(pp);
                pictureBox1.Image = img;
            }
            }
        }
    }

