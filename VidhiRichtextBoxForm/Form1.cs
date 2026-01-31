using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidhiRichtextBoxForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
                //richTextBox1.SelectionColor=colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "text Files(*.txt)|*.txt| Rich Text Format(*.rtf)|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 2)
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|Rich Text Format(*.rtf)|*.rtf";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(openFileDialog1.FileName.EndsWith(".rtf"))richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.RichText);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            }
        }
    }
}


