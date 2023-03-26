create procedure AMN.spDELSeason 
@SeasonId int
as
begin

	delete from AMN.Season where SeasonId = @SeasonId

end