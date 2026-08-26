namespace Pertemuan_2
{
    public partial class lblProfile_mahasiswa : Form
    {
        public lblProfile_mahasiswa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world! " + Environment.NewLine +
                "Nama : " + textBox1.Text + Environment.NewLine +
                "NIM  : " + textBox2.Text + Environment.NewLine +
                "KOM  : " + textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
