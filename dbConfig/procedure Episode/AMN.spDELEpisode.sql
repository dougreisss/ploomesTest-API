use prjAnime
go
create procedure AMN.spDELEpisode
@EpisodeId int,
@AnimeId int 
as
begin

	delete from AMN.Episode where EpisodeId = @EpisodeId and AnimeId = @AnimeId

end