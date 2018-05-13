using System.IO;
using System.Net;

String URI = "https://www.magicsoftware.com";

Console.WriteLine("Requesting: " + URI);

WebClient webClient = new WebClient();
            webClient.Headers["User-Agent"] =
                "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
                "(compatible; MSIE 6.0; Windows NT 5.1; " +
                ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";

        try
        {
            // actually execute the GET request
            string ret = webClient.DownloadString("http://www.google.com/");
 
            // ret now contains the contents of the webpage
            Console.WriteLine("First 256 bytes of response: " + ret.Substring(0,265));
        }
        catch (WebException we)
        {
            // WebException.Status holds useful information
            Console.WriteLine(we.Message + "\n" + we.Status.ToString());
        }
        catch (NotSupportedException ne)
        {
            // other errorscsi
            Console.WriteLine(ne.Message);
        }
