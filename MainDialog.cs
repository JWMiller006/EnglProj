using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model_ConsoleApp;
using EnglProj.Backend.CS_Code;
using System.Threading;
using System.Diagnostics;

namespace EnglProj
{
    public partial class MainDialog : Form
    {
        public MainDialog()
        {
            InitializeComponent();
            Reset(); 
        }

        private void DevelopmentBttn_Click(object sender, EventArgs e)
        {
            // Open Dev Page
            Form form = new Develop();
            form.Show();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Exit();
            return; 
        }

        private void Exit()
        {
            Program.Restart = false;
            this.Close();
            this.Dispose();
            return; 
        }

        private void Restart()
        {
            Program.Restart = true;
            this.Close();
            this.Dispose();
            return; 
        }

        private void Reset()
        {
            this.outputText.Text = "Hello, I am Meursault from Albert Camus' The Stranger. " +
                "Talk with me by entering text into the lower text box marked \"Input\"\n";
            this.inputText.Text = string.Empty;
            this.inputText.SelectionAlignment = HorizontalAlignment.Right;
            this.TotalClicks = 0; 
            this.Clr();
            return; 
        }

        private void Clr()
        {
            this.UI.Text = string.Empty;
            this.UI.Enabled = true;
            this.SentBttn.Enabled = true;
            this.UI.ForeColor = Color.Gainsboro;
            this.UI.BackColor = Color.Black;
        }

        private int TotalClicks = 0; 

        #region Toolstrip Controls

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Restart();
            return; 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Exit();
            return; 
        }

        private void restartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Restart();
            return; 
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Reset();
            return; 
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Reset();
            return; 
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Exit();
            return; 
        }

        private void restartToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Restart();
            return;
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DevelopmentBttn.Enabled = true; 
        }

        private void deactivateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DevelopmentBttn.Enabled = false; 
        }

        #endregion

        /// <summary>
        /// Runs analysis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SentBttn_Click(object sender, EventArgs e)
        {
            if (this.UI.Text != "" && this.UI.Text != string.Empty)
            {
                this.RunText(); 
            }
            else
            {
                this.outputText.Text += "\n\nYou didn't input any text, though " +
                    "it really doesn't matter, nothing matters";
                SentBttn.Enabled = false; 
                Thread.Sleep(1000);
                SentBttn.Enabled = true; 
            }
            TotalClicks++; 
            if (TotalClicks > 10)
            {
                this.Clr();
                this.Reset();
                TotalClicks = 0; 
            }
        }

        private void RunText()
        {
            this.UI.Enabled = false;
            this.SentBttn.Enabled = false;
            this.UI.ForeColor = Color.Gray;
            this.UI.BackColor = Color.DarkGray;

            // Analyze Text
            Program.Quote = this.UI.Text;

            this.MeursaultsMind.RunWorkerAsync(); 
        }

        private void MeursaultsMind_DoWork(object sender, DoWorkEventArgs e)
        {
            QuoteType quoteType = QuoteType.Statement;
            QuoteType opt = QuoteType.Optional; 
            if (Program.Quote.IndexOf('?') != -1)
            {
                // This is a question
                quoteType = QuoteType.Answer; 
            }
            else
            {
                quoteType = QuoteType.Question;
                opt = QuoteType.Statement; 
            }
            Program.DevMessage = quoteType.ToString() + opt.ToString(); 
            MeursaultsMind.ReportProgress(40);
            float sentiment = SentimentalAnalysis.RunAnalysis(Program.Quote);
            Program.Response = SentimentalAnalysis.GetQuote(sentiment, quoteType, opt); 
        }

        private void MeursaultsMind_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.outputText.Text += $"\n\n{Program.Response}";
            this.inputText.Text += $"{Program.Quote}\n\n";
            if (this.DevelopmentBttn.Enabled)
            {
                this.outputText.Text += "\nLoaded and finished"; 
            }
            this.Clr();
        }

        private void MeursaultsMind_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (this.DevelopmentBttn.Enabled)
            {
                Form form = new()
                {
                    Size = new Size(300, 300),
                    Text = "Dev Message: " + Program.DevMessage + ", Progress: " + e.ProgressPercentage,
                    StartPosition = FormStartPosition.CenterScreen,
                    Parent = this.ParentForm
                };
                form.Show();
                Debug.Write(form.Text);
            }
            Debug.WriteLine("No");
            Debug.Flush();
        }

        private void developmentPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new About();
            form.Show(); 
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Use .net8
            Program.Version = DotNetType.net8;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Use .net6
            Program.Version = DotNetType.net6; 
        }
    }
}
