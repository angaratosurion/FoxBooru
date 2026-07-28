using FoxBooru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoxBooru.Search
{

    public class sizebooru : SearchBooru
    {

        public override int EngineID { get { return EngineIDs.Rule34; } }
        public override string  Engine { get { return "sizebooru"; } }
        public sizebooru()
			: base("http://size.booru.org/index.php?page=dapi&s=post&q=index", "tag", "pid", "limit", false)
		{
        }
    }
}
