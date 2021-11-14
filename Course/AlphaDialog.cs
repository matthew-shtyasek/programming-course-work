using System;
using System.Windows.Forms;

namespace Course {
    public partial class inputAlph : Form {
        public inputAlph() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            button1.Enabled = Convert.ToBoolean(textBox1.Text.Length);
        }

        private void button1_Click(object sender, EventArgs e) {
            ceasarForm.alpha = textBox1.Text.ToLower();
            ceasarForm.dictId = -1;
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
