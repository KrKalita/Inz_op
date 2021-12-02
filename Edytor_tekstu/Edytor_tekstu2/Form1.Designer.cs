
namespace Edytor_tekstu2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nowyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.otwórzToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zapiszToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.drukujToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.wytnijToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.kopiujToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.wklejToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pomocToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(-2, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(801, 410);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripButton,
            this.otwórzToolStripButton,
            this.zapiszToolStripButton,
            this.drukujToolStripButton,
            this.toolStripSeparator,
            this.wytnijToolStripButton,
            this.kopiujToolStripButton,
            this.wklejToolStripButton,
            this.toolStripSeparator1,
            this.pomocToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nowyToolStripButton
            // 
            this.nowyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nowyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nowyToolStripButton.Image")));
            this.nowyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nowyToolStripButton.Name = "nowyToolStripButton";
            this.nowyToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.nowyToolStripButton.Text = "&Nowy";
            this.nowyToolStripButton.Click += new System.EventHandler(this.nowyToolStripButton_Click);
            // 
            // otwórzToolStripButton
            // 
            this.otwórzToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.otwórzToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("otwórzToolStripButton.Image")));
            this.otwórzToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.otwórzToolStripButton.Name = "otwórzToolStripButton";
            this.otwórzToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.otwórzToolStripButton.Text = "&Otwórz";
            this.otwórzToolStripButton.Click += new System.EventHandler(this.otwórzToolStripButton_Click);
            // 
            // zapiszToolStripButton
            // 
            this.zapiszToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zapiszToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("zapiszToolStripButton.Image")));
            this.zapiszToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zapiszToolStripButton.Name = "zapiszToolStripButton";
            this.zapiszToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.zapiszToolStripButton.Text = "&Zapisz";
            this.zapiszToolStripButton.Click += new System.EventHandler(this.zapiszToolStripButton_Click);
            // 
            // drukujToolStripButton
            // 
            this.drukujToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drukujToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("drukujToolStripButton.Image")));
            this.drukujToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drukujToolStripButton.Name = "drukujToolStripButton";
            this.drukujToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.drukujToolStripButton.Text = "&Drukuj";
            this.drukujToolStripButton.Click += new System.EventHandler(this.drukujToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // wytnijToolStripButton
            // 
            this.wytnijToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wytnijToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("wytnijToolStripButton.Image")));
            this.wytnijToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wytnijToolStripButton.Name = "wytnijToolStripButton";
            this.wytnijToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.wytnijToolStripButton.Text = "&Wytnij";
            this.wytnijToolStripButton.Click += new System.EventHandler(this.wytnijToolStripButton_Click);
            // 
            // kopiujToolStripButton
            // 
            this.kopiujToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kopiujToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("kopiujToolStripButton.Image")));
            this.kopiujToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopiujToolStripButton.Name = "kopiujToolStripButton";
            this.kopiujToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.kopiujToolStripButton.Text = "&Kopiuj";
            this.kopiujToolStripButton.Click += new System.EventHandler(this.kopiujToolStripButton_Click);
            // 
            // wklejToolStripButton
            // 
            this.wklejToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wklejToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("wklejToolStripButton.Image")));
            this.wklejToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wklejToolStripButton.Name = "wklejToolStripButton";
            this.wklejToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.wklejToolStripButton.Text = "&Wklej";
            this.wklejToolStripButton.Click += new System.EventHandler(this.wklejToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // pomocToolStripButton
            // 
            this.pomocToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pomocToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pomocToolStripButton.Image")));
            this.pomocToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pomocToolStripButton.Name = "pomocToolStripButton";
            this.pomocToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.pomocToolStripButton.Text = "&Pomoc";
            this.pomocToolStripButton.Click += new System.EventHandler(this.pomocToolStripButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nowyToolStripButton;
        private System.Windows.Forms.ToolStripButton otwórzToolStripButton;
        private System.Windows.Forms.ToolStripButton zapiszToolStripButton;
        private System.Windows.Forms.ToolStripButton drukujToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton wytnijToolStripButton;
        private System.Windows.Forms.ToolStripButton kopiujToolStripButton;
        private System.Windows.Forms.ToolStripButton wklejToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton pomocToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

