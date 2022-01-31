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

namespace CodeEditor
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // new color choosing dialog
            ColorDialog colorDialog = new ColorDialog();
            // if after showing dialog, user clicked ok
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                // set background color of text box
                fastColoredTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove all text from text-box
            fastColoredTextBox1.Text = "";
        }

        // method, to open file  
        private void OpenDlg()
        {
            // create new open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // open file dialog files extension filter
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                openFileDialog.Filter = "C# File|*.cs|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.VB)
            {
                openFileDialog.Filter = "VB File|*.vb|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                openFileDialog.Filter = "HTML File|*.html|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
            {
                openFileDialog.Filter = "PHP File|*.php|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.XML)
            {
                openFileDialog.Filter = "XML File|*.xml|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JS)
            {
                openFileDialog.Filter = "JS File|*.js|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
            {
                openFileDialog.Filter = "Lua File|*.lua|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Custom)
            {
                openFileDialog.Filter = "C# File|*.cs|Any File|*.*";
            }
            else
            {
                openFileDialog.Filter = "Any File|*.*";
            }
            // if after showing dialog, clicked ok
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // open file
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                // place file text to text box
                fastColoredTextBox1.Text = sr.ReadToEnd();
                // close file
                sr.Close();
                // text of this window = path of currently opened file
                this.Text = openFileDialog.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           OpenDlg();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // save file
                StreamWriter streamWriter = new StreamWriter(this.Text);
                streamWriter.Write(fastColoredTextBox1.Text);
                streamWriter.Close();
            } 
            catch 
            {
                SaveDlg();                
            }
        }

        // save file method
        private void SaveDlg()
        {
            // new save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // filter 
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                saveFileDialog.Filter = "C# File|*.cs|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.VB)
            {
                saveFileDialog.Filter = "VB File|*.vb|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                saveFileDialog.Filter = "HTML File|*.html|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
            {
                saveFileDialog.Filter = "PHP File|*.php|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.XML)
            {
                saveFileDialog.Filter = "XML File|*.xml|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JS)
            {
                saveFileDialog.Filter = "JS File|*.js|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
            {
                saveFileDialog.Filter = "Lua File|*.lua|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Custom)
            {
                saveFileDialog.Filter = "C# File|*.cs|Any File|*.*";
            }
            else
            {
                saveFileDialog.Filter = "Any File|*.*";
            }
            // if after showing dialog, user clicked ok
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(saveFileDialog.FileName);
                sr.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDlg();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close application
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // new color choosing dialog
            ColorDialog colorDialog = new ColorDialog();
            // if after showing dialog, user clicked ok
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // set text color of text box
                fastColoredTextBox1.ForeColor = colorDialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // new font choosing dialog
            FontDialog fontDialog = new FontDialog();
            // if after showing dialog, user clicked ok
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // set font of text box
                fastColoredTextBox1.Font = fontDialog.Font; 
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void undiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Redo();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowGoToDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void vBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB;
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP;
        }

        private void javascriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.SQL;
        }

        private void lUAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void gramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
