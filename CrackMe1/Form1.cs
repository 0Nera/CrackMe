using System;
using System.Windows.Forms;

namespace CrackMe
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(textBox1.Text == "4203") {
                MessageBox.Show("Great. Отлично!");
            } else {
                MessageBox.Show("Password incorect. Неверный пароль!");
            }
        }
    }
}
