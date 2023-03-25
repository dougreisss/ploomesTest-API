use prjAnime
go
create procedure AMN.spLSTEpisodeByAnimeId
@AnimeId int 
as
begin

	select 

		E.EpisodeId,
		E.AnimeId,
		E.EpisodeName,
		EpisodeLength = convert(VARCHAR, E.EpisodeLength, 24),
		E.EpisodeSynopsis,
		E.EpisodeRealease,
		E.SeasonId
	
	from AMN.Episode E where E.AnimeId = @AnimeId

end