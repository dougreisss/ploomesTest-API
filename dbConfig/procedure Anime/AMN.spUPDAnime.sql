use prjAnime
go
create procedure AMN.spUPDAnime
@AnimeId int,
@Title varchar(255),
@OriginalTitle varchar(255),
@Synopsis text,
@RealeaseYear date,
@StudioId int
as
begin

update AMN.Anime 
set 
Title = @Title, 
OriginalTitle = @OriginalTitle, 
Synopsis = @Synopsis, 
RealeaseYear = @RealeaseYear,
StudioId = @StudioId

where AnimeId = @AnimeId

end