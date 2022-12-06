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

//used to compile files
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.CodeDom;
using FastColoredTextBoxNS;

namespace SanIDE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class EllipseStyle : Style
        {
            public override void Draw(Graphics gr, Point position, Range range)
            {
                //get size of rectangle
                Size size = GetSizeOfRange(range);
                //create rectangle
                Rectangle rect = new Rectangle(position, size);
                //inflate it
                rect.Inflate(2, 2);
                //get rounded rectangle
                var path = GetRoundedRectangle(rect, 7);
                //draw rounded rectangle
                gr.DrawPath(Pens.Red, path);
            }
        }
        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void themeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.BackColor = cd.Color;
                //menuStrip1.BackColor = cd.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void OpenDlg()
        {
            OpenFileDialog of = new OpenFileDialog();
            //of.Filter = "Text File|*.txt|San File|*.san|San Libaray file|*.sanlib|San Header|*.sanh|San Build File|*.sanbuild|San Core File|*.sancore|Any File|*.*";
            if(fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                of.Filter = "C# Files|*.cs|Any File|*.*";
            }
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.VB)
            {
                of.Filter = "VB Files|*.vb|Any File|*.*";
            }
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
            {
                of.Filter = "PHP Files|*.php|Any File|*.*";
            }
           else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JS)
            {
                of.Filter = "JS Files|*.js|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.XML)
            {
                of.Filter = "XML Files|*.xml|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                of.Filter = "HTML Files|*.html|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.SQL)
            {
                of.Filter = "SQL Files|*.sql|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
            {
                of.Filter = "LUA Files|*.lua|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
            {
                of.Filter = "San Files|*.san|Any File|*.*";
            }
            else
            {
                of.Filter = "Any File|*.*";
            }

            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                fastColoredTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = of.FileName;
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDlg();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            } 
            catch
            {
                OpenDlg();
            }
        }

        private void SaveDlg()
        {
            SaveFileDialog of = new SaveFileDialog();
            // sf.Filter = "Text File|*.txt|San File|*.san|San Libaray file|*.sanlib|San Header|*.sanh|San Build File|*.sanbuild|San Core File|*.sancore|Any File|*.*";
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                of.Filter = "C# Files|*.cs|Any File|*.*";
            }
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.VB)
            {
                of.Filter = "VB Files|*.vb|Any File|*.*";
            }
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
            {
                of.Filter = "PHP Files|*.php|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JS)
            {
                of.Filter = "JS Files|*.js|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.XML)
            {
                of.Filter = "XML Files|*.xml|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                of.Filter = "HTML Files|*.html|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.SQL)
            {
                of.Filter = "SQL Files|*.sql|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
            {
                of.Filter = "LUA Files|*.lua|Any File|*.*";
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
            {
                of.Filter = "San Files|*.san|Any File|*.*";
            }
            else
            {
                of.Filter = "Any File|*.*";
            }
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(of.FileName);
                sr.Write(fastColoredTextBox1.Text);
                sr.Close();
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDlg();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void themeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.ForeColor = cd.Color;
                //menuStrip1.ForeColor = cd.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog cd = new FontDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Font = cd.Font;
                //menuStrip1.ForeColor = cd.Color;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();

        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.FindForm();
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP;

        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.SQL;

        }

        private void javaScriptJsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;

        }

        private void vBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB;

        }

        private void lUAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;

        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;

        }

        private void sanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP;

        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.XML;

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                HTMLPreview h = new HTMLPreview(fastColoredTextBox1.Text);
                h.Show();
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Executable File|*.exe";
                string OutPath = "?.exe";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    OutPath = sf.FileName;
                }
                //compile code:
                //create c# code compiler
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                //create new parameters for compilation and add references(libs) to compiled app
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll" });
                //is compiled code will be executable?(.exe)
                parameters.GenerateExecutable = true;
                //output path
                parameters.OutputAssembly = OutPath;
                //code sources to compile
                string[] sources = { fastColoredTextBox1.Text };
                //results of compilation
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, sources);

                //if has errors
                if (results.Errors.Count > 0)
                {
                    string errsText = "";
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        errsText = "(" + CompErr.ErrorNumber +
                                    ")Line " + CompErr.Line +
                                    ",Column " + CompErr.Column +
                                    ":" + CompErr.ErrorText + "" +
                                    Environment.NewLine;
                    }
                    //show error message
                    MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //run compiled app
                    System.Diagnostics.Process.Start(OutPath);
                }
            }
            else
            {
                MessageBox.Show("Scappy IDE: Error, Can not run this language code");
            }
        }

        private void runTheCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                HTMLPreview h = new HTMLPreview(fastColoredTextBox1.Text);
                h.Show();
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Executable File|*.exe";
                string OutPath = "?.exe";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    OutPath = sf.FileName;
                }
                //compile code:
                //create c# code compiler
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                //create new parameters for compilation and add references(libs) to compiled app
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll" });
                //is compiled code will be executable?(.exe)
                parameters.GenerateExecutable = true;
                //output path
                parameters.OutputAssembly = OutPath;
                //code sources to compile
                string[] sources = { fastColoredTextBox1.Text };
                //results of compilation
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, sources);

                //if has errors
                if (results.Errors.Count > 0)
                {
                    string errsText = "";
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        errsText = "(" + CompErr.ErrorNumber +
                                    ")Line " + CompErr.Line +
                                    ",Column " + CompErr.Column +
                                    ":" + CompErr.ErrorText + "" +
                                    Environment.NewLine;
                    }
                    //show error message
                    MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //run compiled app
                    System.Diagnostics.Process.Start(OutPath);
                }
            }
            else
            {
                MessageBox.Show("Scappy IDE: Error, Can not run this language code");
            }
        }
    }
}
