namespace BauCuaGame
{
    public partial class Form1 : Form
    {
        int limit = 0; //tổng số lượt chọn
        public Form1()// constructor 
        {
            InitializeComponent();// Khởi tạo các component
            ptb_Tom.Image = Image.FromFile(@"C:\Users\Acer\Desktop\BCTC\tom.png");
            ptb_Tom.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Start_MouseHover(object sender, EventArgs e)
        {
            btn_Start.BackColor = Color.LightBlue;
        }

        private void btn_Start_MouseLeave(object sender, EventArgs e)
        {
            btn_Start.BackColor = Color.White;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Random r = new Random(); // tạo để dùng random
            // Tạo 1 mảng chứa đường dẫn đến ảnh
            string[] imagesURL = new string[]
            {
                @"C:\Users\Acer\Desktop\BCTC\Bau.jpg",
                @"C:\Users\Acer\Desktop\BCTC\cua.jpg",
                @"C:\Users\Acer\Desktop\BCTC\tom.png",
                @"C:\Users\Acer\Desktop\BCTC\ca.png",
                @"C:\Users\Acer\Desktop\BCTC\ga.jpg",
                @"C:\Users\Acer\Desktop\BCTC\huou.jpg"
            };
            // Random ra 3 giá trị từ 0 đến 5 để lấy đường dẫn từ mảng URL theo vị trí
            int r1 = r.Next(imagesURL.Length);
            int r2 = r.Next(0, 5);
            int r3 = r.Next(imagesURL.Length);
            // Gán ảnh cho pictureBox
            ptb_R1.Image = Image.FromFile(imagesURL[r1]);
            ptb_R2.Image = Image.FromFile(imagesURL[r2]);
            ptb_R3.Image = Image.FromFile(imagesURL[r3]);
        }
        public void DatCuoc(Label lb)
        {
            lb.Text = Convert.ToInt32(lb.Text) + 1 + "";
            limit++; // Khi ấn vào thì tổng số lượt lựa chọn cũng tăng 1
            if (limit > 3)
            {
                limit -= Convert.ToInt32(lb.Text); // giảm đúng bằng số lượng update về 0
                lb.Text = "0";
            }
            // MessageBox.Show(limit.ToString()); // chỉ để check thôi
        }

        private void ptb_Bau_Click(object sender, EventArgs e)
        {
            DatCuoc(lb_Bau);
            //lb_Bau.Text = Convert.ToInt32(lb_Bau.Text) + 1 + "";
            //limit++; // Khi ấn vào thì tổng số lượt lựa chọn cũng tăng 1
            //if (limit > 3)
            //{
            //    limit -= Convert.ToInt32(lb_Bau.Text); // giảm đúng bằng số lượng update về 0
            //    lb_Bau.Text = "0";
            //}
            //MessageBox.Show(limit.ToString());
        }

        private void ptb_Cua_Click(object sender, EventArgs e)
        {
            DatCuoc(lb_Cua);
        }

        private void ptb_Tom_Click(object sender, EventArgs e)
        {
            DatCuoc(lb_Tom);
        }

        private void ptb_Ca_Click(object sender, EventArgs e)
        {
            DatCuoc(lb_Ca);
        }

        private void ptb_Ga_Click(object sender, EventArgs e)
        {
            DatCuoc(lb_Ga);
        }

        private void ptb_Huou_Click(object sender, EventArgs e)
        {
            DatCuoc(lb_Huou);
        }
    }
}