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
                string helpmnge = "download  { tag}  to download images for this tag \n" +
                    "tags {character} to search for images and save its tags to a file\n" +
                    "mark {ptagfile} {image directory} to tag the fiels in the given " +
                    "directory weith tags " +
                    "included in the file";


                Console.WriteLine(helpmnge);
               

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
