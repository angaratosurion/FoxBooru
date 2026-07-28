using FoxBooru.Models;
using System;

namespace FoxBooru.Search
{
	// http://rule34.xxx/index.php?page=help&topic=dapi

	public class Rule34 : SearchBooru
	{
		public override int EngineID { get { return EngineIDs.Rule34; } }
        public override string Engine{ get { return "Rule34"; } }

        public Rule34()
			: base("http://rule34.xxx/index.php?page=dapi&s=post&q=index", "tag", "pid", "limit", false)
		{
		}
	}
}
