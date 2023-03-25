use prjAnime
go
create procedure AMN.spINSAnime
@Title varchar(255),
@OriginalTitle varchar(255),
@Synopsis text,
@RealeaseYear date,
@StudioId int
as
begin

	insert into AMN.Anime (Title, OriginalTitle, Synopsis, RealeaseYear, StudioId) values (@Title, @OriginalTitle, @Synopsis, @RealeaseYear, @StudioId)

end
