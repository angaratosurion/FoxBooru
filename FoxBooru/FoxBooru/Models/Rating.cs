using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoxBooru.Models
{
	public enum Ratings : int
	{
		Safe = 0,
		Questionable = 1,
		Explicit = 2,
		Extreme = 3,
		All = 99
	}
}
