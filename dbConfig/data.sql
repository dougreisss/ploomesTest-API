use prjAnime
go

insert into AMN.Season (SeasonName) values ('Temporada 1')

insert into AMN.Studio (StudioName) values ('Nippon Animation')

insert into AMN.Genre (GenreName) values ('Aventura')

insert into AMN.Genre (GenreName) values ('Fantasia')

insert into AMN.Genre (GenreName) values ('Arte Marciais')

insert into AMN.Anime (Title, OriginalTitle, Synopsis, RealeaseYear, StudioId) values ('Hunter x Hunter', 'Hunter Hunter', 'A série conta a história de Gon Freecss, um garoto de 12 anos que pretende se tornar um Hunter, um caçador de tesouros, lugares perdidos e criaturas estranhas.', '1998-03-03', 1)

insert into AMN.Anime_Genre values (1, 1)

insert into AMN.Anime_Genre values (1, 2)

insert into AMN.Anime_Genre values (1, 3)

insert into AMN.Episode (AnimeId, EpisodeName, EpisodeLength, EpisodeSynopsis, SeasonId, EpisodeRealease) values (1, 'T01 E01 · Despedida x e x Amigos', '00:20:00', 'Para realizar o Exame Hunter e seguir os passos de seu pai, o garoto Gon precisa antes cumprir a promessa que fez a Mito, a mulher que o criou.', 1, '2011-10-02')

insert into AMN.Episode (AnimeId, EpisodeName, EpisodeLength, EpisodeSynopsis, SeasonId, EpisodeRealease) values (1, 'T01 E02 · O Teste x dos x Testes', '00:20:00', 'Ao pegar um atalho para o local do Exame, Gon, Leorio e Kurapika encontram umas velhinhas que só permitirão que eles passem se responderem corretamente a uma pergunta.', 1, '2011-10-09')
