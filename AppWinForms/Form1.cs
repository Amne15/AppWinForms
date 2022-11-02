using System.Diagnostics.CodeAnalysis;

namespace AppWinForms
{
    public partial class Form1 : Form
    {
        private int num1;
        private int num2;
        private int sumaar;
        public Form1()

        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = int.Parse(tboxNum1.Text);
                num2 = int.Parse(tboxNum2.Text);
                sumaar = num1 + num2;
                tboxResult.Text = sumaar.ToString();
                //MessageBox.Show("");
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tboxNum1.Text = "";
            tboxNum2.Text = "";
            tboxResult.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lNum1_Click(object sender, EventArgs e)
        {

        }
    }
}