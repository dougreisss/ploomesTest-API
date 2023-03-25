use prjAnime
go
create procedure AMN.spINSEpisode
@AnimeId int,
@EpisodeName varchar(250),
@EpisodeLength time,
@EpisodeSynopsis text,
@EpisodeRealease date,
@SeasonId int
as
begin

	insert into AMN.Episode (AnimeId, EpisodeName, EpisodeLength, EpisodeSynopsis, EpisodeRealease, SeasonId) values (@AnimeId, @EpisodeName, @EpisodeLength, @EpisodeSynopsis, @EpisodeRealease, @SeasonId)

end