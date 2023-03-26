use prjAnime
go
create or alter procedure AMN.spLSTAllAnimesByAnimeIdAndEpisodeId 
@AnimeId int,
@EpisodeId int
as
begin

	select  
	
		A.AnimeId,
		A.Title,
		A.OriginalTitle,
		A.Synopsis,
		A.RealeaseYear,
		S.StudioId,
		S.StudioName,
		G.GenreId,
	    G.GenreName,
		E.EpisodeId,
		E.EpisodeName,
		E.EpisodeSynopsis,
		EpisodeLength = convert(VARCHAR, E.EpisodeLength, 24),
		E.EpisodeRealease,
		SE.SeasonId,
		SE.SeasonName

	from AMN.Anime A

	inner join AMN.Episode E 
	on A.AnimeId = E.AnimeId

	inner join AMN.Studio S 
	on S.StudioId = A.StudioId

	inner join AMN.Anime_Genre ANG
	on ANG.AnimeId = A.AnimeId

	inner join AMN.Genre G 
	on G.GenreId = ANG.GenreId

	inner join AMN.Season SE
	on SE.SeasonId = E.SeasonId

	where E.AnimeId = @AnimeId and E.EpisodeId = @EpisodeId

end
