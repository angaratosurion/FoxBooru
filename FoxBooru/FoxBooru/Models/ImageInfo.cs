using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace FoxBooru.Models
{
	public class ImageInfo
	{
        [JsonIgnore]
        public int		EngineID		{ get; set; }
        public string Id { get; set; }
        
        
		public String Created_At		{ get; set; }

		public string	Source			{ get; set; }
        public string Extention { get; set; }
        public string md5 { get; set; }
        [JsonIgnore]
        public Ratings Rating { get; set; }

        public string	OrigUrl			{ get; set; }
		public int		OrigWidth		{ get; set; }
		public int		OrigHeight		{ get; set; }
		public long		OrigFileSize	{ get; set; }

		/*public string	SampleUrl		{ get; set; }
		public long		SampleFileSize	{ get; set; }
		public int		SampleWidth		{ get; set; }
		public int		SampleHeight	{ get; set; }

		public string	ThumbUrl		{ get; set; }
		public int		ThumbWidth		{ get; set; }
		public int		ThumbHeight		{ get; set; }*/

		public IList<string> TagsAll		{ get; set; }
		public IList<string> TagsGeneral	{ get; set; }
		public IList<string> TagsArtist		{ get; set; }
		public IList<string> TagsCharacter	{ get; set; }
		public IList<string> TagsCopyRight	{ get; set; }
		public IList<string> TagsSource		{ get; set; }
	}
}
