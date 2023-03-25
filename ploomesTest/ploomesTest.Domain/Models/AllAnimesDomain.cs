using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Models
{
    public class AllAnimesDomain
    {
		public int AnimeId { get; set; }
		public string Title { get; set; }
		public string OriginalTitle { get; set; }
		public string Synopsis { get; set; }
		public DateTime RealeaseYear { get; set; }
		public int StudioId { get; set; }
		public string StudioName { get; set; }
		public int GenreId { get; set; }
		public string GenreName { get; set; }
		public int EpisodeId { get; set; }
		public string EpisodeName { get; set; }
		public string EpisodeSynopsis { get; set; }
		public string EpisodeLength { get; set; }
		public DateTime EpisodeRealease { get; set; }
		public int SeasonId { get; set; }
		public string SeasonName { get; set; }
	}
}
