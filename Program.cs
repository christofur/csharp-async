using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var action = new Chapter1.DumpWebPages();
            action.DumpWebPage("http://www.reddit.com");
            action.DumpWebPageAsync("http://www.guardian.co.uk");
            Console.Read();
        }
    }
}
