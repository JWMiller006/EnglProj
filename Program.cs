using EnglProj.Backend.CS_Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EnglProj
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string path = Application.StartupPath + QuotesAddition;
                string text = File.ReadAllText(path);
                //File.WriteAllText(path, System.Text.Json.JsonSerializer.Serialize(QuoteList)); 
                Program.QuoteList = System.Text.Json.JsonSerializer.Deserialize<List<Quote>>(text);
            }
            catch
            {

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Prog();
            // I want closer to 0
        }

        public static bool Restart = false;

        public static string Quote = string.Empty;

        public static string Response = string.Empty;

        public static string DevMessage = string.Empty; 

        private static void Prog()
        {
            Restart = false; 
            Application.Run(new MainDialog());
            if (Restart)
            {
                Prog();
            }

        }

        internal static readonly string QuotesAddition = @"/Backend/Data/Responses.json";

        internal static List<Quote> QuoteList = [ ];
    }
}
