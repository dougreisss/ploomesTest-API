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

create table AMN.Tag
(
	TagId int not null identity(1,1),
	TagName varchar(150),
	constraint pk_Tag primary key (TagId)
)

create table AMN.Anime 
(
	AnimeId int not null identity(1,1),
	Title varchar(255),
	OriginalTitle varchar(255),
	Synopsis text,
	StudioId int,
	constraint pk_Anime primary key (AnimeId),
	constraint fk_Anime_Studio foreign key (StudioId)
	references AMN.Studio (StudioId)
)

create table AMN.Anime_Tags
(
	AnimeId int,
	TagId int,
	constraint pk_Anime_Tags primary key (AnimeId, TagId),
	constraint fk_Anime_Tags foreign key (AnimeID)
	references AMN.Anime (AnimeID),
	constraint fk_Tag_Anime foreign key (TagId)
	references AMN.Tag (TagId)
)

create table AMN.Episode 
(
	EpisodeId int identity(1,1),
	AnimeId int,
	EpisodeName varchar(250),
	EpisodeLength decimal(10, 2),
	EpisodeSynopsis text,
	SeasonId int,
	constraint fk_Episode primary key (EpisodeId, AnimeId),
	constraint fk_Episode_Anime foreign key (AnimeId)
	references AMN.Anime (AnimeId),
	constraint fk_Episode_Season foreign key (SeasonId)
	references AMN.Season (SeasonId)
)