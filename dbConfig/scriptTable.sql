use prjAnime
go
create table AMN.Season 
(
	SeasonId int not null identity(1,1),
	SeasonName varchar(150),
	constraint pk_Season primary key (SeasonID)
)

create table AMN.Studio 
(
	StudioId int not null identity(1,1),
	StudioName varchar(255),
	constraint pk_Studio primary key (StudioId)
)

create table AMN.Genre
(
	GenreId int not null identity(1,1),
	GenreName varchar(150),
	constraint pk_Tag primary key (GenreId)
)

create table AMN.Anime 
(
	AnimeId int not null identity(1,1),
	Title varchar(255),
	OriginalTitle varchar(255),
	Synopsis text,
	RealeaseYear date, 
	StudioId int,
	constraint pk_Anime primary key (AnimeId),
	constraint fk_Anime_Studio foreign key (StudioId)
	references AMN.Studio (StudioId)
)

create table AMN.Anime_Genre
(
	AnimeId int,
	GenreId int,
	constraint pk_Anime_Genre primary key (AnimeId, GenreId),
	constraint fk_Anime_Genre foreign key (AnimeID)
	references AMN.Anime (AnimeID),
	constraint fk_Genre_Anime foreign key (GenreId)
	references AMN.Genre (GenreId)
)

create table AMN.Episode 
(
	EpisodeId int identity(1,1),
	AnimeId int,
	EpisodeName varchar(250),
	EpisodeLength time,
	EpisodeSynopsis text,
	EpisodeRealease date,
	SeasonId int,
	constraint fk_Episode primary key (EpisodeId, AnimeId),
	constraint fk_Episode_Anime foreign key (AnimeId)
	references AMN.Anime (AnimeId),
	constraint fk_Episode_Season foreign key (SeasonId)
	references AMN.Season (SeasonId)
)