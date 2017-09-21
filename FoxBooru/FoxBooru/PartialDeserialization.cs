using FoxBooru.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBooru
{
    public class PartialDeserialization
    {
        public List<ImageInfo> Desrialise(String json)
        {
             try
            {
                List<ImageInfo> ap = null;
                int i = -1;
                if (json != null)
                {
                    JArray dsarr = JArray.Parse(json);
                    ap = new List<ImageInfo>();

                    for (i = 0; i < dsarr.Count; i++)
                    {


                        var resuls = dsarr[i];
                        //foreach (JToken result in results)
                        {
                            ImageInfo img = new ImageInfo();
                            img.Rating = Helper.ToRating(resuls.Value<String>("rating"));
                            
                            img.Id = resuls.Value<String>("id");
                            img.md5 = resuls.Value<String>("md5");
                            img.Source = resuls.Value<String>("source");
                            img.Created_At = resuls.Value<String>("created_at");
                            img.OrigFileSize = resuls.Value<long>("file_size");
                            img.OrigWidth = resuls.Value <int > ("width");
                            img.OrigHeight = resuls.Value<int>("height");
                            img.OrigUrl = resuls.Value<String>("file_url");
                            ap.Add(img);

                        }
                    }
                }
                return ap;
                }
            catch (Exception ex)
            {

                Base.ErrorReporting(ex);
                return null;
            }

        }
        }
    }

