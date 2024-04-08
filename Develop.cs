using EnglProj.Backend.CS_Code;
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
using System.Linq.Expressions;

namespace EnglProj
{
    public partial class Develop : Form
    {
        public Develop()
        {
            InitializeComponent();
            this.RefreshControl();
        }

        private void sentimentInput_Scroll(object sender, EventArgs e)
        {
            this.displayNum.Text = "Sentiment: " + sentimentInput.Value.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Quote temp = new()
            {
                Text = this.quoteBox.Text,
                Level = this.sentimentInput.Value,

            };
            Program.QuoteList.Add(temp);
            switch (this.TypeInput.Value)
            {
                case (1): 
                    temp.QuoteType = QuoteType.Statement;
                    break; 
                case (2):
                    temp.QuoteType = QuoteType.Question;
                    break;
                case (3):
                    temp.QuoteType = QuoteType.Answer;
                    break;
                default:
                    temp.QuoteType = QuoteType.Statement;
                    break;
            }
            string path = Application.StartupPath + Program.QuotesAddition;
            File.WriteAllText(path, System.Text.Json.JsonSerializer.Serialize(Program.QuoteList));

            this.quoteBox.Text = string.Empty;
            this.sentimentInput.Value = 0; 
            this.displayNum.Text = "Sentiment: " + this.sentimentInput.Value.ToString();
            this.RefreshControl();
        }

        private void RefreshControl()
        {
            List<List<Quote>> quotes = [[],[],[]];
            foreach (Quote quote in Program.QuoteList)
            {
                if (quote.QuoteType == QuoteType.Answer)
                {
                    quotes[0].Add(quote); 
                }
                else if (quote.QuoteType == QuoteType.Question)
                {
                    quotes[1].Add(quote); 
                }
                else if (quote.QuoteType == QuoteType.Statement)
                {
                    quotes[2].Add(quote); 
                }
            }
            int count = 0; 
            foreach (TreeNode node in this.quotesOut.Nodes)
            {
                node.Nodes.Clear();
                foreach (Quote quote in quotes[count])
                {
                    node.Nodes.Add("\"" + quote.Text + "\"  Level: " + quote.Level); 
                }
                count++; 
            }

        }

        private void sentimentInput_Scroll_1(object sender, EventArgs e)
        {
            this.sentimentInput_Scroll(sender, e); 
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            this.addButton_Click(sender, e);
            this.RefreshControl();
        }
    }
}
