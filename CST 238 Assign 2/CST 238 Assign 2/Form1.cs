using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CST_238_Assign_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        private void openhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "bmp (*.bmp)|*.bmp";
                ofd.FileName = "";
                ofd.Title = "Open";

                if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
                {
                    pictureBox.Image = Bitmap.FromFile(ofd.FileName);
                    this.Text = string.Format("CST 238 Assign2 - {0}", Path.GetFileName(ofd.FileName));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "File name not found");

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "bmp (*.bmp)|*.bmp";

                if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
                {
                    pictureBox.Image.Save(sfd.FileName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Enter a Filename");

            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineToolStripMenuItem.Checked = true;
            rectangleToolStripMenuItem.Checked = false;
            eclipseToolStripMenuItem.Checked = false;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineToolStripMenuItem.Checked = false;
            rectangleToolStripMenuItem.Checked = true;
            eclipseToolStripMenuItem.Checked = false;
        }

        private void eclipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineToolStripMenuItem.Checked = false;
            rectangleToolStripMenuItem.Checked = false;
            eclipseToolStripMenuItem.Checked = true;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blackToolStripMenuItem.Checked = true;
            whiteToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blackToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = true;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blackToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blackToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blackToolStripMenuItem.Checked = false;
            whiteToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Would you like to save?", "Save ",
            //    MessageBoxButtons.YesNoCancel);

            //if (result == System.Windows.Forms.DialogResult.Yes)
            //    System.IO.File.WriteAllText(FileNameBox.Text, TextBox.Text);

            //if (result == System.Windows.Forms.DialogResult.Cancel)
            //    e.Cancel = true;

            //
            //FIGURE OUT HOW TO SAVE PROPERLY
            //
        }

    }
}
