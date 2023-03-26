create procedure AMN.spINSAnimeGenre
@AnimeId int,
@GenreId int
as
begin

	insert into AMN.Anime_Genre values (@AnimeId, @GenreId)

end