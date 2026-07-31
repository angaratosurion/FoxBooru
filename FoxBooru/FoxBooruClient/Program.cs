namespace FoxBooruClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            DanbooruDownloader danbooruDownloader = new DanbooruDownloader(); 
            ImageTager imageTager = new ImageTager();
            string cmd, argument,filename,argeument2;
             cmd = args[0];
            argument = args[1];
            
          //  filename = args[3];
            if (cmd == null)
            {

               

            }
            else if (cmd == "download")
            {
                if (argument != null)
                {
                    await danbooruDownloader.DownloadImages(argument);
                }
            }
            else if (cmd == "tags")
            {
                if (argument != null )
                {
                    danbooruDownloader.DownloadTagsAndSave(argument);
                }
            }
            else if (cmd =="mark")
            {
                if (argument != null  && (args[2]!=null))
                {
                      argeument2= args[2];
                    imageTager.TagImages(argument, argeument2);

                }
            }

        }
    }
}
