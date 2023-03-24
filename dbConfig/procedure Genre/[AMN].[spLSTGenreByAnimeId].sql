USE [prjAnime]
GO
create procedure [AMN].[spLSTGenreByAnimeId]
@AnimeId int
as
begin

	select G.GenreId, G.GenreName from AMN.Genre G

	inner join AMN.Anime_Genre AG
	on AG.GenreId = G.GenreId

	where AG.AnimeId = @AnimeId

end
GO


