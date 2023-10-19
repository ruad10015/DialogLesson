using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
               //this.BackColor = colorDialog1.Color;
                foreach (var item in this.Controls)
                {
                    if(item is Label lb)
                    {
                        lb.ForeColor = colorDialog1.Color;
                    }
                    else if(item is Button bt)
                    {
                        bt.ForeColor = colorDialog1.Color;
                    }
                }
            }
        }

        private void changeFontBtn_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                foreach (var item in this.Controls)
                {
                    if(item is Label lb)
                    {
                        lb.Font= fontDialog1.Font;
                        lb.ForeColor = fontDialog1.Color;
                    }
                    else if(item is Button bt)
                    {
                        bt.Font= fontDialog1.Font;
                        bt.ForeColor = fontDialog1.Color;
                    }
                }
            }
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Text= folderBrowserDialog1.SelectedPath;
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            var openDialog=new OpenFileDialog();

            openDialog.Filter = "All Files(*.*)|*.*|Text Files(*.txt)| *.txt|Doc (*.docx)| *.docx";
            openDialog.FilterIndex = 2;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sr=File.OpenText(openDialog.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Text Files(*.txt)| *.txt|Doc (*.docx)| *.docx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (var sw=new StreamWriter(save.FileName))
                {
                    sw.Write(richTextBox1.Text);
                    richTextBox1.Text = String.Empty;
                }
            }
        }
    }
}
