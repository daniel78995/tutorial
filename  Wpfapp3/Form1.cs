using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int no; 
        private void Form1_Load(object sender, EventArgs e)
        {
            no = 1;
            lblNo.Text = "第" + no.ToString() + "張";
            picShow.Image = new Bitmap("pic" + no.ToString() + ".jpg");
            
            picShow.SizeMode = PictureBoxSizeMode.StretchImage;
            btnP.Enabled = false; 
        }
        
        private void btnN_Click(object sender, EventArgs e)
        {
            no++; 
            lblNo.Text = "第" + no.ToString() + "張";
            btnP.Enabled = true;  
            if (no == 4) btnN.Enabled = false;
            picShow.Image = new Bitmap("pic" + no.ToString() + ".jpg");
            picShow.Size = new Size(640, 400);
        }
        
        private void btnP_Click(object sender, EventArgs e)
        {
            no--;
            lblNo.Text = "第" + no.ToString() + "張";
            btnN.Enabled = true; 
            if (no == 1) btnP.Enabled = false;  
            picShow.Image = new Bitmap("pic" + no.ToString() + ".jpg");
            picShow.Size = new Size(640, 400); 
        }
       
        private void btnS_Click(object sender, EventArgs e)
        {
            for (int w = 640; w >= 320; w -= 20) 
            {
                picShow.Size = new Size(w, Convert.ToInt32(w * 0.8));
                DateTime now = DateTime.Now;    
                do   
                {
                    Application.DoEvents(); 
                } while ((DateTime.Now - now).TotalSeconds < 0.1);
            }
        }
       
        private void btnB_Click(object sender, EventArgs e)
        {
            for (int w = 640; w <=10000; w -= 20)
            {
                picShow.Size = new Size(w, Convert.ToInt32(w * 2));
                DateTime now = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while ((DateTime.Now - now).TotalSeconds < 0.1);
            }
        }
    }
}
