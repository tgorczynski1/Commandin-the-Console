using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; // for the HttpClient (API)
using static System.Console; // Allows me to direcly call static methonds on the Console class, without the classname qualifier 

namespace Repo
{
    class Program
    {
        const string API_BASE = "https://gitignore.io/api/";
        const string API_LINES =  API_BASE + "list?format=lines";

        static void Main(string[] args)
        {
            // Use the HttpClient to grab content from a website
            var client = new HttpClient();
            var templateNames = 
                client.GetAsync(API_LINES, HttpCompletionOption.ResponseContentRead).GetAwaiter().GetResult();

            WriteLine(templateNames);
        }
    }
}
