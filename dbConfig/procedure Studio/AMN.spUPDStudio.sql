create procedure AMN.spUPDStudio 
@StudioId int,
@StudioName varchar(255)
as
begin

	update AMN.Studio set StudioName = @StudioName where StudioId = @StudioId

end