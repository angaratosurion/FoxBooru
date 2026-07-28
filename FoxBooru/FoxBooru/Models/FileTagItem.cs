using System;
using System.Collections.Generic;
using System.Text;

namespace FoxBooru.Models
{
    public  class FileTagItem
    {
        public string MD5 { get; set; }
        public string Extention { get; set; }
        public List<string> Tags { get; set; }
    }
}
