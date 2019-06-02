using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace DownloadAFileFromNet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("https://www.desicomments.com/wp-content/uploads/Samurai-Jack-Doing-Practise-Dc36.gif", "SamuraiJack.gif");
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(WebException e)
            {
                Console.WriteLine(e.InnerException);
            }
            catch(NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
