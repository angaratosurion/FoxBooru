using FoxBooru;
using FoxBooru.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TagLib;

namespace FoxBooruClient
{
    public class ImageTager
    {
        public void TagImages(string tagfile , string imgdir)
        {
			try
			{
                if ( tagfile  !=null && imgdir !=null && System.IO.File.Exists(tagfile) 
                    && Directory.Exists(imgdir))
                {
                    List<FileTagItem> tags = new List<FileTagItem>();
                    String[] files = Directory.GetFiles(imgdir);
                    if (files != null)
                    {
                        foreach (String file in files)
                        {
                            var tag = tags.FirstOrDefault(x => x.MD5 ==
                            Path.GetFileNameWithoutExtension(file));
                            string filePath = Path.Combine(imgdir, file);
                            using var imgfile = TagLib.File.Create(filePath);
                            if (imgfile.GetTag(TagTypes.AllTags) is 
                                TagLib.Image.CombinedImageTag imageTag)
                            {
                                // 1. Διάβασμα των υπαρχόντων keywords
                                var existingKeywords = imageTag.Keywords ?? Array.Empty<string>();
                                var newKeywords = tag.Tags;
                                // 2. Συγχώνευση υπαρχόντων και νέων keywords (χωρίς διπλότυπα)
                                var updatedKeywords = existingKeywords
                                    .Union(newKeywords, StringComparer.OrdinalIgnoreCase)
                                    .ToArray();
                                
                                // 3. Ενημέρωση των Keywords/Tags
                                imageTag.Keywords = updatedKeywords;

                               

                                // 4. Αποθήκευση των αλλαγών στο αρχείο
                                imgfile.Save();

                              
                            }
                        }

                    }

                }
                  
			}
            catch (Exception ex)
            {

                Base.ErrorReporting(ex);
                 
            }
        }
    }
}
