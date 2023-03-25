create procedure AMN.spINSStudio
@StudioName varchar(255)
as
begin

	insert into AMN.Studio (StudioName) values (@StudioName) 

end