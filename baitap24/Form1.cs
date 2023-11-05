using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace baitap24

{
    public partial class Form1 : Form
    {
        // Tạo một đối tượng Random
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            // Đăng ký phương thức xử lý sự kiện Paint cho Form
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Lấy đối tượng Graphics từ tham số PaintEventArgs
            Graphics g = e.Graphics;
            // Sinh ra các số ngẫu nhiên cho tọa độ x, y của chuỗi "Paint Event"
            int x = random.Next(0, this.Width - 100);
            int y = random.Next(0, this.Height - 50);
            // Vẽ chuỗi "Paint Event" tại vị trí ngẫu nhiên trên Form
            g.DrawString("Paint Event", new Font("Arial", 20), Brushes.Red, x, y);
        }


    }
}