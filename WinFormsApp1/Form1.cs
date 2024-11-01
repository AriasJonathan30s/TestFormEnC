namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string planta = "";
        int cantidad = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Elegiste " + this.cantidad + " de  " + this.planta));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.planta = comboBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.cantidad = Int32.Parse(textBox1.Text);
        }
    }
}
