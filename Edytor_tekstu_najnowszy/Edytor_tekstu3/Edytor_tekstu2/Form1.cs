using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;

namespace Edytor_tekstu2
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        Choices clist = new Choices();
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
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void otwórzToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName);
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
            
            MessageBox.Show("Text Editor jest prostym programem do edycji tekstu.\nPoza wpisywaniem oraz kasowaniem tekstu dostępne jest kilka funkcji:\nNowy - tworzy pusty dokument.\nOtwórz - otwiera folder z zapisanymi plikami.\nZapisz - zapisuje bieżący dokument.\nDrukuj  - drukuje bieżący dokument.\nWytnij - wycina zaznaczony fragment tekstu.\nKopiuj - kopiuje zaznaczony fragment tekstu do schowka.\nWklej - wkleja zapisany w schowku tekst.\nDwa zestawy gotowych funckji - wyświetla na ekran funkcje.\nStart i Stop Speech-To-Text - umożliwia wypisywanie funkcji na ekran przy użyciu rozpoznania głosu.","Pomoc");
        }

        private void drukujToolStripButton_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, this.Font, Brushes.Black, 150, 150);
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

        private void btnEnable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            btnEnable.Enabled = false;
            btnDisable.Enabled = true;




            //clist.Add(new string[] { });

           // recEngine.RequestRecognizerUpdate();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new String[] { "document class", "use package", "begin document", "author", "title", "date", "make title", "table of contents", "part", "chapter", "section", "subsection", "subsubsection", "paragraph", "subparagraph", "emphasis", "italic", "slanted", "bold", "teletype", "small capitals", "sans serif", "underline", "tiny", "scriptsize", "footnotesize", "small", "normal size", "large size", "large large size", "large large large size", "huge size", "huge huge size", "bibliography style", "bibliography", "addbibresource", "newpage", "linebreak", "pagebreak", "medskip", "smallskip", "vspace", "bigskip", "normal math mode", "inline math mode", "special math mode", "superscript", "subscript", "frac", "d frac", "square root", "left", "right", "begin array", "arcus sinus", "arcus cosinus", "arcus tangens", "cosinus", "cosinus hyperbolic", "cotangens", "cotangens hyperbolic", "cosecans", "degree", "determinant", "dimension", "exponential", "logarithm", "sinus", "tangens", "tangens hyperbolic" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

        }
      


        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "document class":
                    richTextBox1.Text += "\\documentclass[options]{class}\n";
                    
                    break;
                case "use package":
                    richTextBox1.Text += "\\usepackage[options]{ package}\n";
                    break;
                case "begin document":
                    richTextBox1.Text += "\\begin{document}\n    \\usepackage[options]{package}\n\\end{document}\n";
                    break;
                case "author":
                    richTextBox1.Text += "\\author{names}\n";
                    break;
                case "title":
                    richTextBox1.Text += "\\title{title}\n";
                    break;
                case "date":
                    richTextBox1.Text += "\\date{date}\n";
                    break;
                case "make title":
                    richTextBox1.Text += "\\maketitle{}\n";
                    break;
                case "table of contents":
                    richTextBox1.Text += "\\tableofcontents\n";
                    break;
                case "part":
                    richTextBox1.Text += "\\part{title}\n";
                    break;
                case "chapter":
                    richTextBox1.Text += "\\chapter{title}\n";
                    break;
                case "section":
                    richTextBox1.Text += "\\section{title}\n";
                    break;
                case "subsection":
                    richTextBox1.Text += "\\subsection{title}\n";
                    break;
                case "subsubsection":
                    richTextBox1.Text += "\\subsubsection{title}\n";
                    break;
                case "paragraph":
                    richTextBox1.Text += "\\paragraph{title}\n";
                    break;
                case "subparagraph":
                    richTextBox1.Text += "\\subparagraph{title}\n";
                    break;
                case "emphasis":
                    richTextBox1.Text += "\\emph{}\n";
                    break;
                case "italic":
                    richTextBox1.Text += "\\textit{}\n";
                    break;
                case "slanted":
                    richTextBox1.Text += "\\textsl{}\n";
                    break;
                case "bold":
                    richTextBox1.Text += "\\textbf{}\n";
                    break;
                case "teletype":
                    richTextBox1.Text += "\\texttt{}\n";
                    break;
                case "small capitals":
                    richTextBox1.Text += "\\textsc{}\n";
                    break;
                case "sans serif":
                    richTextBox1.Text += "\\textsf{}\n";
                    break;
                case "underline":
                    richTextBox1.Text += "\\underline{}\n";
                    break;
                case "tiny":
                    richTextBox1.Text += "{\\tiny}\n";
                    break;
                case "scriptsize":
                    richTextBox1.Text += "{\\scriptsize}\n";
                    break;
                case "footnotesize":
                    richTextBox1.Text += "{\\footnotesize}\n";
                    break;
                case "small":
                    richTextBox1.Text += "{\\small}\n";
                    break;
                case "normal size":
                    richTextBox1.Text += "{\\normalsize}\n";
                    break;
                case "large size":
                    richTextBox1.Text += "{\\large}\n";
                    break;
                case "large large size":
                    richTextBox1.Text += "{\\Large}\n";
                    break;
                case "large large large size":
                    richTextBox1.Text += "{\\LARGE}\n";
                    break;
                case "huge size":
                    richTextBox1.Text += "{\\huge}\n";
                    break;
                case "huge huge size":
                    richTextBox1.Text += "{\\Huge}\n";
                    break;
                case "bibliography style":
                    richTextBox1.Text += "\\bibliographystyle{}\n";
                    break;
                case "bibliography":
                    richTextBox1.Text += "\\bibliography{}\n";
                    break;
                case "addbibresource":
                    richTextBox1.Text += "\\addbibresource{bibfile}\n";
                    break;
                case "newpage":
                    richTextBox1.Text += "{\\newpage }\n";
                    break;
                case "linebreak":
                    richTextBox1.Text += "{\\linebreak }\n";
                    break;
                case "pagebreak":
                    richTextBox1.Text += "{\\pagebreak }\n";
                    break;
                case "medskip":
                    richTextBox1.Text += "{\\medskip }\n";
                    break;
                case "smallskip":
                    richTextBox1.Text += "{\\smallskip }\n";
                    break;
                case "vspace":
                    richTextBox1.Text += "{\\vspace{skip} }\n";
                    break;
                case "bigskip":
                    richTextBox1.Text += "{\\bigskip }\n";
                    break;
                case "normal math mode":
                    richTextBox1.Text += "$ $\n";
                    break;
                case "inline math mode":
                    richTextBox1.Text += "\\( \\)\n";
                    break;
                case "special math mode":
                    richTextBox1.Text += "\\[ \\]\n";
                    break;
                case "superscript":
                    richTextBox1.Text += "^{}\n";
                    break;
                case "subscript":
                    richTextBox1.Text += "_{}\n";
                    break;
                case "frac":
                    richTextBox1.Text += "\\frac{licznik}{mianownik}\n";
                    break;
                case "d frac":
                    richTextBox1.Text += "\\dfrac{licznik}{mianownik}\n";
                    break;
                case "square root":
                    richTextBox1.Text += "\\sqrt{}\n";
                    break;
                case "left":
                    richTextBox1.Text += "\\left\n";
                    break;
                case "right":
                    richTextBox1.Text += "\\right\n";
                    break;
                case "begin array":
                    richTextBox1.Text += "\\begin{array}{columns}\n content\n \\end{array}";
                    break;
                case "arcus cosinus":
                    richTextBox1.Text += "\\arccos\n";
                    break;
                case "arcus sinus":
                    richTextBox1.Text += "\\arcsin\n";
                    break;
                case "arcus tangens":
                    richTextBox1.Text += "\\arctan\n";
                    break;
                case "cosinus":
                    richTextBox1.Text += "\\cos\n";
                    break;
                case "cosinus hyperbolic":
                    richTextBox1.Text += "\\cosh\n";
                    break;
                case "cosecans":
                    richTextBox1.Text += "\\csc\n";
                    break;
                case "degree":
                    richTextBox1.Text += "\\deg\n";
                    break;
                case "determinant":
                    richTextBox1.Text += "\\det\n";
                    break;
                case "dimension":
                    richTextBox1.Text += "\\dim\n";
                    break;
                case "exponential":
                    richTextBox1.Text += "\\exp\n";
                    break;
                case "logarithm":
                    richTextBox1.Text += "\\log\n";
                    break;
                case "sinus":
                    richTextBox1.Text += "\\sin\n";
                    break;
                case "tangens":
                    richTextBox1.Text += "\\tan\n";
                    break;
                case "tangens hyperbolic":
                    richTextBox1.Text += "\\tanh\n";
                    break;
                case "cotangens":
                    richTextBox1.Text += "\\cot\n";
                    break;
                case "cotangens hyperbolic":
                    richTextBox1.Text += "\\coth\n";
                    break;

                    


            }

        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
           
            recEngine.RecognizeAsyncStop();
            btnEnable.Enabled = true;
            btnDisable.Enabled = false;
            
            
            

        }
    
    }
}
