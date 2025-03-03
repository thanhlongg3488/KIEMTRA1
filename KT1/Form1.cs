namespace KT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(textboxusername.Text == "admin" && textboxmatkhau.Text == "admin")
            {
                Form2 formDangNhapThanhCong = new Form2();
                this.Hide();
                formDangNhapThanhCong.Show();
            }
        }
    }
}
