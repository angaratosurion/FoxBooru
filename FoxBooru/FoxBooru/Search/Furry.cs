using FoxBooru.Models;
using System;

namespace FoxBooru.Search
{
	// http://furry.booru.org/index.php?page=help&topic=dapi

	public class Furry : SearchBooru
	{
		public override int EngineID { get { return EngineIDs.Furry; } }

        public override string Engine { get { return "Furry"; } }
        public Furry()
			: base("http://furry.booru.org/index.php?page=dapi&s=post&q=index", "tag", "pid", "limit", false)
		{
		}
	}
}
