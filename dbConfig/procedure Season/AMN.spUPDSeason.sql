create procedure AMN.spUPDSeason
@SeasonId int,
@SeasonName varchar(150)
as
begin

	update AMN.Season set SeasonName = @SeasonName where SeasonId = @SeasonId

end