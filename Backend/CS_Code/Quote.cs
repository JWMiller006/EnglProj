using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglProj.Backend.CS_Code
{
    internal class Quote
    {
        public string Text { get; set; }

        public int Level { get; set; }

        public QuoteType QuoteType { get; set; }

        private static readonly string DefaultText = "It doesn't really matter"; 

        public static Quote Default
        {
            get
            {
                return new()
                {
                    Text = Quote.DefaultText,
                    Level = 5,
                    QuoteType = QuoteType.Statement
                };
            }
        }
    }

    internal enum QuoteType
    {
        Statement = 1, 
        Answer = 2, 
        Question = 3,
        Optional = 0,
    }
}
