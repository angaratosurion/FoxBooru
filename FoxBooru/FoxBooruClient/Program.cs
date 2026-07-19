namespace FoxBooruClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanbooruDownloader danbooruDownloader = new DanbooruDownloader(); 
            string cmd, argument,filename;
             cmd = args[1];
            argument = args[2];
          //  filename = args[3];
            if (cmd == null)
            {

               

            }
            else if (cmd == "download")
            {
                if (argument != null)
                {
                    danbooruDownloader.DownloadImages(argument);
                }
            }
            else if (cmd == "tags")
            {
                if (argument != null )
                {
                    danbooruDownloader.DownloadTagsAndSave(argument);
                }
            }

        }
    }
}
