
use prjAnime
go
create procedure AMN.spLSTAllAnimes
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

	left join AMN.Episode E 
	on A.AnimeId = E.AnimeId

	left join AMN.Studio S 
	on S.StudioId = A.StudioId

	outer apply 
	(
		select 
		AGN.GenreId 
		from AMN.Anime_Genre AGN
		where AGN.AnimeId = E.EpisodeId
	) ATA

	left join AMN.Genre G 
	on G.GenreId = ATA.GenreId

	left join AMN.Season SE
	on SE.SeasonId = E.SeasonId

end
