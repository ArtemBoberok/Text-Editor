using System;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;

namespace Pw16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                this.Text = "Файл открыт " + fn;
                try
                {
                    StreamReader sr = new StreamReader(fn);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения \n" + ex.ToString());
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                this.Text = "Файл сохранен " + fn;
                if (fn != string.Empty)
                {
                    FileInfo fi = new FileInfo(fn);
                    try
                    {
                        StreamWriter sw = fi.CreateText();
                        sw.Write(textBox1.Text);
                        sw.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка записи \n" + ex.ToString());
                    }
                }
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void открытьPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 pdf = new Form3();
            pdf.Show();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void параметрыСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
