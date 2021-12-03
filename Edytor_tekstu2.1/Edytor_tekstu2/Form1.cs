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
            //5:20
            //richTextBox1.Text=
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
            //4:44????
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
            //Msgbox("to jest proste", MsgBoxStyle.Information);
        }

        private void drukujToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void documentclassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\documentclass[options]{class}\n";
        }

        private void usepackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\usepackage[options]{ package}\n";
        }

        private void begindocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\begin{document}\n    \\usepackage[options]{package\n\\end{document}";
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\author{names}";
        }

        private void titleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\title{title}";
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\date{date}";
        }

        private void maketitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\maketitle";
        }

        private void tableofcontentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\tableofcontents";
        }

        private void partToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.Text += "\\part{title}";
        }

        private void chapterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\chapter{title}";
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\section{title}";
        }

        private void subsectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\subsection{title}";
        }

        private void subsubsectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\subsubsection{title}";
        }

        private void paragraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\paragraph{title}";
        }

        private void subparagraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\subparagraph{title}";
        }

        private void wyróżnionyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\emph{}";
        }

        private void kursywaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\texttit{}";
        }

        private void pochyonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\textsl{}";
        }

        private void pogrubionyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\textbf{}";
        }

        private void maszynowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\texttt{}";
        }

        private void kapitalikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\textsc{}";
        }

        private void bezszeryfowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\textsf{}";
        }

        private void podkreślenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\underlin{}";
        }

        private void bibliographystyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\bibliographystyle{}";
        }

        private void bibliographyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\bibliography{}";
        }

        private void addbibresourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\addbibresource{bibfile}";
        }

        private void tinyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\tiny }";
        }

        private void scriptsizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\scriptsize }";
        }

        private void footnotesizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\footnotesize }";
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\small }";
        }

        private void normallsizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\normallsize }";
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\large }";
        }

        private void largeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\Large }";
        }

        private void lARGEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\LARGE }";
        }

        private void hugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\huge }";
        }

        private void hugeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\Huge }";
        }

        private void newpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\newpage }";
        }

        private void linebreakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\linebreak";
        }

        private void pagebreakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\pagebreak";
        }

        private void medskipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\medskip";
        }

        private void smallskipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\smallskip";
        }

        private void vspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\vspace{skip}";
        }

        private void bigskipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "{\\bigskip";
        }

        private void fracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\frac{licznik}{mianownik}";
        }

        private void trybMatematycznyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "$  $";
        }

        private void latexInlineMathModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\(  \\)";
        }

        private void trybMatematycznyWyróżnionyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\[  \\]";
        }

        private void indeksDolnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "_{}";
        }

        private void indeksGórnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "^{}";
        }

        private void dfracToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\dfrac{licznik}{mianownik}";
        }

        private void sqrtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\sqrt{}";
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\left";
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\right";
        }

        private void beginarrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\left \\begin{array}{columns}\n    content\n\\end{array}";
        }

        private void arccosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\arcos";
        }

        private void arcsinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\arcsin";
        }

        private void arctanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\arctan";
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\cos";
        }

        private void coshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\cosh";
        }

        private void cotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\cot";
        }

        private void cothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\coth";
        }

        private void cscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\csc";
        }

        private void degToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\deg";
        }

        private void detToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\det";
        }

        private void dimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\dim";
        }

        private void expToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\exp";
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\log";
        }

        private void sinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\sin";
        }

        private void tanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\tan";
        }

        private void tanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\\tanh";
        }
    }
}
