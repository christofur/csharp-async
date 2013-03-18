using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AsyncCSharp.Chapter1
{
    public class DumpWebPages
    {
        /// <summary>
        /// Blocking version of DumpWebPage
        /// </summary>
        public void DumpWebPage(string uri) {
            var webClient = new WebClient();
            var page = webClient.DownloadString(uri);
            Console.WriteLine(page);
        }

        /// <summary>
        /// Non-blocking version of DumpWebPage
        /// </summary>
        public async void DumpWebPageAsync(string uri) {
            var webClient = new WebClient();
            var page = await webClient.DownloadStringTaskAsync(uri);
            Console.WriteLine(page);
        }
    }
}
