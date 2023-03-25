create procedure AMN.spUPDEpisode 
@EpisodeId int,
@AnimeId int,
@EpisodeName varchar(250),
@EpisodeLength time,
@EpisodeSynopsis text,
@EpisodeRealease date,
@SeasonId int
as
begin

update AMN.Episode set EpisodeName = @EpisodeName, EpisodeLength = @EpisodeLength, EpisodeSynopsis = @EpisodeSynopsis, EpisodeRealease = @EpisodeRealease
where AnimeId = @AnimeId and EpisodeId = @EpisodeId

end