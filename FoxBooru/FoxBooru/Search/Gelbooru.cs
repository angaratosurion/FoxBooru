using FoxBooru.Models;
using System;

namespace FoxBooru.Search
{
	// http://www.gelbooru.com/index.php?page=dapi&s=post&q=index

	public class Gelbooru : SearchBooru
	{
		public override int EngineID { get { return EngineIDs.Gelbooru; } }
        public override string Engine { get { return "Gelbooru"; } }

        public Gelbooru()
			: base("http://www.gelbooru.com/index.php?page=dapi&s=post&q=index&json=1", 
				  "tags", "pid", "limit", true)
		{
		}
	}
}
