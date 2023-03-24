use prjAnime
go
create procedure AMN.spINSGenre
@GenreName varchar(150)
as
begin

insert into  AMN.Genre (GenreName) values (@GenreName)

end