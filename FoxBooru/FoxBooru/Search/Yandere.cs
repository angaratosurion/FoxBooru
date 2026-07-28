using FoxBooru.Models;
using System;

namespace FoxBooru.Search
{
	// http://yande.re/help/api

	public class Yandere : SearchBooru
	{
		public override int EngineID { get { return EngineIDs.Yandere; } }
        public override string Engine { get { return "Yandere"; } }

        public Yandere()
			: base("http://yande.re/post.json", "tags", "page", "limit", true)
		{
		}
	}
}
