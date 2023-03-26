create procedure AMN.spDELGenre
@GenreId int
as
begin	

	delete from AMN.Genre where GenreId = @GenreId

end 