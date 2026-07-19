namespace FoxBooruClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanbooruDownloader danbooruDownloader = new DanbooruDownloader(); 
            string cmd, argument;
             cmd = args[1];
            argument = args[2];
            if (cmd == null)
            {

               

            }
            else if (cmd == "download")
            {
                if (argument != null)
                {
                    danbooruDownloader.DownloadRandomimages(argument);
                }
            }
            else if (cmd == "tags")
            {

            }

        }
    }
}
