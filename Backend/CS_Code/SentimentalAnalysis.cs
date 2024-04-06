using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Model_ConsoleApp;
using SkiaSharp;
//using Model_Handler; 
using EnglProj;

namespace EnglProj.Backend.CS_Code
{
    public static class SentimentalAnalysis
    {
        public static float RunAnalysis(string text)
        {
            Debug.AutoFlush = true; 
            Debug.WriteLine("Part 1");
            //Model_Handler.Program.Main(["run", text]);
            //Load sample data
            /*var sampleData = new Model.ModelInput()
            {
                SentimentText = text,
            };

            //Load model and predict output
            var result = Model.Predict(sampleData);



            float outputScore;//Model_Handler.Program.Score[1];
            /*Model.ModelInput sampleData = new()
            {
                SentimentText = text,
            };
            Debug.WriteLine("Part 2");
            var sortedScoresWithLabel = Model.Predict(sampleData);
            ushort count = 0;
            outputScore = result.Score[1];
            Debug.WriteLine("Part 3");
            Debug.WriteLine(result.Score[0]);
            Debug.WriteLine(outputScore);
            /*foreach (var score in sortedScoresWithLabel)
            {
                if (count == 1)
                {
                    outputScore = score.Value;
                    break; 
                }
                count++;
            }*/

            float outputScore;

            Process proc = new()
            {
                StartInfo = new()
                {
                    FileName = "ModelHandler/EnglishProject.exe",
                    Arguments = $"run \"{text}\"",
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false, 
                }
            };
            proc.Start();
            proc.WaitForExit();
            string output = proc.StandardOutput.ReadToEnd();

            Debug.WriteLine(output); 

            outputScore = (float)Convert.ToDouble(output);

            Debug.WriteLine("Part 4: Finished");
            return outputScore; 
        }

        private static readonly Random RNG = new();

        private static float RunOffset(float sentiment)
        {
            Offset += RNG.Next(-1, 1) * (float)RNG.NextDouble();
            sentiment += Offset; 
            if (sentiment < 0)
            {
                sentiment = 0f;
                Offset = 0f; 
            }
            else if (sentiment > 10)
            {
                sentiment = 10f;
                Offset = 0f; 
            }
            return sentiment; 
        }

        private static float Offset { get; set; } = 0f; 

        /// <summary>
        /// Gets a quote semi-randomly generated from the list of quotes that are loaded into the engine
        /// </summary>
        /// <param name="sentiment">the floating point number of the level of sentiment, 
        /// nicer responses for lower #s</param>
        /// <param name="quoteType">the type of quote that is desired</param>
        /// <param name="optional">if more than one type of quote is desired, 
        /// then more than one type will be added to list of eligible quotes</param>
        /// <returns>a randomly selected quote from the eligible list</returns>
        internal static string GetQuote(float sentiment, QuoteType quoteType, QuoteType optional = QuoteType.Optional)
        {
            List<Quote> eligibleQuotes = [];
            sentiment *= 750f; 
            sentiment = RunOffset(sentiment); 
            foreach (var quote in Program.QuoteList)
            {
                if ((quote.QuoteType == quoteType || quote.QuoteType == optional) &&
                    ((float)quote.Level < (sentiment + 0.75f) && (float)quote.Level > (sentiment - 0.75f)))
                {
                    eligibleQuotes.Add(quote); 
                }
            }
            Debug.WriteLine("modified sentiment: " + sentiment);
            Debug.Flush();
            foreach (Quote quote in eligibleQuotes)
            {
                Debug.WriteLine(quote.Text);
            }
            if (eligibleQuotes.Count <= 0)
            {
                return Quote.Default.Text; 
            }
            return eligibleQuotes[RNG.Next(0, eligibleQuotes.Count - 1)].Text;
        }
    }
}
