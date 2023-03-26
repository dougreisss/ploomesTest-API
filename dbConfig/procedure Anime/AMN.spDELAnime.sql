create procedure AMN.spDELAnime
@AnimeId int 
as
begin
	delete from AMN.Anime where AnimeId = @AnimeId 
end 