using FoxBooru;
using FoxBooru.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TagLib;
using TagLib.Matroska;

namespace FoxBooruClient
{
    public class ImageTager
    {
        public void TagImages(string tagfile , string imgdir)
        {
			try
			{
                if ( tagfile  !=null && imgdir !=null) //&& System.IO.File.Exists(tagfile) 
                                                       //&& Directory.Exists(imgdir))
                {
                    string json =System.IO.File.ReadAllText(tagfile);
                    List<FileTagItem> tags =
                        JsonConvert.DeserializeObject<List<FileTagItem>>(json);

                    var supportedExtensions = new[] { ".jpg", ".jpeg", ".png", ".tif", ".tiff" };

                    var files = Directory.GetFiles(imgdir)
                                              
                        .Where(f => supportedExtensions.Contains(Path.GetExtension(f).ToLower()));

                    if (files != null)
                    {
                        foreach (String file in files)
                        {
                            var tag = tags.FirstOrDefault(x => x.MD5 ==
                            Path.GetFileNameWithoutExtension(file));
                            string filePath = Path.Combine(imgdir, 
                                Path.GetFileName(file));
                            var fileAttributes = System.IO.File.GetAttributes(filePath);
                            if (fileAttributes.HasFlag(FileAttributes.ReadOnly))
                            {
                                System.IO.File.SetAttributes(filePath, fileAttributes & ~FileAttributes.ReadOnly);
                            }
                            try
                            {
                                using var imgfile = TagLib.Image.File.Create(filePath);
                                if (imgfile.Tag != null && tag != null
                                    && imgfile is TagLib.Image.File imageFile)
                                {
                                    var imgtag = imageFile.ImageTag;

                                    // 1. Διάβασμα των υπαρχόντων keywords
                                    var existingKeywords = imgtag.Keywords ?? Array.Empty<string>();
                                    var newKeywords = tag.Tags;
                                    // 2. Συγχώνευση υπαρχόντων και νέων keywords (χωρίς διπλότυπα)
                                    var updatedKeywords = existingKeywords
                                        .Union(newKeywords, StringComparer.OrdinalIgnoreCase)
                                        .ToArray();

                                    // 3. Ενημέρωση των Keywords/Tags
                                    imgfile.Tag.Comment = updatedKeywords.ToString();
                                    imgtag.Keywords = updatedKeywords;

                                    //Keywords = updatedKeywords;



                                    // 4. Αποθήκευση των αλλαγών στο αρχείο
                                    imgfile.Save();
                                }
                            }
                            catch
                            {


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
