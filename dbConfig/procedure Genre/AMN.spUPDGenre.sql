create procedure AMN.spUPDGenre
@GenreId int,
@GenreName varchar(150)
as
begin

	update AMN.Genre set GenreName = @GenreName where GenreId = @GenreId

end