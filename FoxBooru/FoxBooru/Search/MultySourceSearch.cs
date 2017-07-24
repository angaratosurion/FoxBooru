using FoxBooru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBooru.Search
{
    public class MultySourceSearch
    {
        SearchBooru[] engines = { new Gelbooru(), new Danbooru(),  new Konachan(),  new Yandere() };
    public List<ImageInfo> Search (SearchOption option)
        {
            try
            {
                List<ImageInfo> ap = null;
                if ( option!=null)
                {
                    ap = new List<ImageInfo>();
                    foreach(var  eng in engines)
                    {
                        var imglst = eng.Search(option).ToArray();
                        ap.AddRange(imglst);
                    }
                }

                return ap;

            }
            catch (Exception)
            {

                throw;
               // return null;
            }
        }

    }
}
