create procedure AMN.spLSTSeasonByAnimeId
@AnimeId int
as
begin

	select distinct 
		
		S.SeasonId, S.SeasonName 
	
	from AMN.Season S 

	inner join AMN.Episode E
	on E.SeasonId = S.SeasonId

	where E.AnimeId = @AnimeId

end