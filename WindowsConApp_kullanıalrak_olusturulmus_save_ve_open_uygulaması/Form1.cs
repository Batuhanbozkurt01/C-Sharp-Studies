using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsConApp_kullanıalrak_olusturulmus_save_ve_open_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open butonu
            string fname1;
            openFileDialog1.ShowDialog(this);
            fname1 = openFileDialog1.FileName;
            textBox1.Text = fname1;
            if (fname1 != null)
            {
                richTextBox1.LoadFile(fname1, RichTextBoxStreamType.PlainText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save butonu
            string fname1;
            saveFileDialog1.ShowDialog(this);
            fname1 = saveFileDialog1.FileName;
            textBox1.Text = fname1;
            if (fname1 != null)
            {
                richTextBox1.SaveFile(fname1, RichTextBoxStreamType.PlainText);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
