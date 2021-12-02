using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edytor_tekstu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nowyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void zapiszToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void otwórzToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void wytnijToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopiujToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wklejToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void pomocToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void drukujToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
