create procedure AMN.spDELStudio
@StudioId int
as
begin

	delete from AMN.Studio where StudioId = @StudioId

end