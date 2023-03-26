create procedure AMN.spDELGenre
@GenreId int
as
begin	

	delete from AMN.Anime_Genre where GenreId = @GenreId
	delete from AMN.Genre where GenreId = @GenreId

end 