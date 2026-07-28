using FoxBooru.Models;
using System;

namespace FoxBooru.Search
{
	// http://konachan.com/help/api

	public class Konachan : SearchBooru
	{
		public override int EngineID { get { return EngineIDs.Konachan; } }
        public override string Engine  { get { return "Konachan"; }
}

public Konachan()
			: base("http://konachan.com/post.json", "tags", "page", "limit", true)
		{
		}
	}
}
