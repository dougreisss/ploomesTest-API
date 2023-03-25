create procedure AMN.spINSSeason
@SeasonName varchar(150)
as
begin

	insert into AMN.Season (SeasonName) values (@SeasonName)

end