# ploomesTest-API
>REST Api desenvolvida para teste prático onde você pode visualizar, criar, atualizar e deletar items

Swagger endpoints: [SwaggerUI](https://prjanimetest.azurewebsites.net/swagger/index.html)
## Anime
#### `GET /api/Anime/ListAllAnimes`
*Listar todos os animes.*

> Body parameter - No parameter

*Exemplo de retorno:*
>Status code: 200
```json
{
  "data": [
    {
      "animeId": 1,
      "title": "Hunter x Hunter",
      "originalTitle": "Hunter Hunter",
      "synopsis": "A série conta a história de Gon Freecss, um garoto de 12 anos que pretende se tornar um Hunter, um caçador de tesouros, lugares perdidos e criaturas estranhas.",
      "realeaseYear": "1998-03-03T00:00:00",
      "studioId": 1,
      "studioName": "Nippon Animation",
      "genreId": 0,
      "genreName": null,
      "episodeId": 3,
      "episodeName": "T01 E01 · Despedida x e x Amigos",
      "episodeSynopsis": "Para realizar o Exame Hunter e seguir os passos de seu pai, o garoto Gon precisa antes cumprir a promessa que fez a Mito, a mulher que o criou.",
      "episodeLength": "00:20:00",
      "episodeRealease": "2011-10-02T00:00:00",
      "seasonId": 1,
      "seasonName": "Temporada 1"
    }
  ],
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |
| 404 | Not Found | Not Found | vmResult |

#### `GET /api/Anime/ListAllAnimesById`
*Listar anime pelo id do anime e do id do episódio.*

> Parameter 

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| AnimeId     | query | integer(int32) |  Id do anime.                                                                              |
| EpisodeId | query | integer(int32) |  Id do episódio.                                                                                |
*Exemplo de retorno:*
>Status code: 200
```json
{
  "data": {
    "animeId": 1,
    "title": "Hunter x Hunter",
    "originalTitle": "Hunter Hunter",
    "synopsis": "A série conta a história de Gon Freecss, um garoto de 12 anos que pretende se tornar um Hunter, um caçador de tesouros, lugares perdidos e criaturas estranhas.",
    "realeaseYear": "1998-03-03T00:00:00",
    "studioId": 1,
    "studioName": "Nippon Animation",
    "genreId": 3,
    "genreName": "Arte Marciais",
    "episodeId": 3,
    "episodeName": "T01 E01 · Despedida x e x Amigos",
    "episodeSynopsis": "Para realizar o Exame Hunter e seguir os passos de seu pai, o garoto Gon precisa antes cumprir a promessa que fez a Mito, a mulher que o criou.",
    "episodeLength": "00:20:00",
    "episodeRealease": "2011-10-02T00:00:00",
    "seasonId": 1,
    "seasonName": "Temporada 1"
  },
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |
| 404 | Not Found | Not Found | vmResult |

### `POST /api/Anime/InsertAnime`

*Inserir anime.*

> Body parameter 

```json
{
  "title": "string",
  "originalTitle": "string",
  "synopsis": "string",
  "realeaseYear": "2023-03-26T22:57:42.369Z",
  "studioId": 0
}
```

*Exemplo de retorno:*
>Status code: 200
```json
{
  "data": {
    "title": "teste",
    "originalTitle": "teste",
    "synopsis": "teste",
    "realeaseYear": "2023-03-26T23:01:27.968Z",
    "studioId": 1
  },
  "friendlyErrorMessage": null,
  "message": "Registro inserido com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 201    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

#### `POST /api​/Anime​/InsertAnimeGenre`
*Inserir um gênero para um anime.*

> Parameter 

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| AnimeId     | query | integer(int32) |  Id do anime.                                                                              |
| genreId | query | integer(int32) |  Id do gênero.                                                                                |

*Exemplo de retorno:*
>Status code: 200
```json
{
  "data": null,
  "friendlyErrorMessage": null,
  "message": "Registro inserido com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

#### `PUT /api​/Anime​/UpdateAnime`
*Atualizar algum campo do anime.*

>Body parameter

```json
{
  "animeId": 0,
  "title": "string",
  "originalTitle": "string",
  "synopsis": "string",
  "realeaseYear": "2023-03-26T23:08:00.035Z",
  "studioId": 0
}
```

*Exemplo de retorno:*
>Status code: 200

```json
{
  "data": {
    "animeId": 4,
    "title": "teste",
    "originalTitle": "teste",
    "synopsis": "teste",
    "realeaseYear": "2023-03-26T23:09:42.06Z",
    "studioId": 1
  },
  "friendlyErrorMessage": null,
  "message": "Registro atualizado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

#### `DELETE /api​/Anime​/DeletarAnime`
*Deletar o anime pelo seu id.*

> Parameter

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| AnimeId     | query | integer(int32) |  Id do anime.                                                                              |
                                                                           

*Exemplo de retorno:*
>Status code: 200

```json
{
  "data": null,
  "friendlyErrorMessage": null,
  "message": "Registro deletado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

## Episode
#### `GET /api/Episode/ListEpisodeByAnimeId`
*Listar um episódio pelo id do anime.*

>Parameter

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| AnimeId     | query | integer(int32) |  Id do anime.                                                                              |
                                                                           

*Exemplo de retorno:*
>Status code: 200

```json
{
  "data": [
    {
      "episodeId": 3,
      "animeId": 1,
      "episodeName": "T01 E01 · Despedida x e x Amigos",
      "episodeLength": "00:20:00",
      "episodeSynopsis": "Para realizar o Exame Hunter e seguir os passos de seu pai, o garoto Gon precisa antes cumprir a promessa que fez a Mito, a mulher que o criou.",
      "episodeRealease": "2011-10-02T00:00:00",
      "seasonId": 1
    },
    {
      "episodeId": 4,
      "animeId": 1,
      "episodeName": "T01 E02 · O Teste x dos x Testes",
      "episodeLength": "00:20:00",
      "episodeSynopsis": "Ao pegar um atalho para o local do Exame, Gon, Leorio e Kurapika encontram umas velhinhas que só permitirão que eles passem se responderem corretamente a uma pergunta.",
      "episodeRealease": "2011-10-09T00:00:00",
      "seasonId": 1
    }
  ],
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |
| 404 | Not Found | Not Found | vmResult |

#### `POST /api/Episode/InsertEpisode`
*Inserir um episódio para um anime.*

>Body parameter

```json
{
  "animeId": 4,
  "episodeName": "teste",
  "episodeLength": "10:00",
  "episodeSynopsis": "teste",
  "episodeRealease": "2023-03-26T23:24:31.272Z",
  "seasonId": 1
}
```

*Exemplo de retorno:*
>Status code: 200

```json
{
  "data": {
    "animeId": 1,
    "episodeName": "teste",
    "episodeLength": "10:00",
    "episodeSynopsis": "teste",
    "episodeRealease": "2023-03-26T23:24:31.272Z",
    "seasonId": 1
  },
  "friendlyErrorMessage": null,
  "message": "Registro inserido com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

#### `PUT /api/Episode/UpdateEpisode`
*Atualizar algum campo do episódio*

>Body parameter

```json
{
  "episodeId": 8,
  "animeId": 1,
  "episodeName": "teste",
  "episodeLength": "20:00",
  "episodeSynopsis": "teste",
  "episodeRealease": "2023-03-26T23:39:05.624Z",
  "seasonId": 1
}
```

*Exemplo de retorno:*
>Status code: 200

```json
{
  "data": {
    "episodeId": 8,
    "animeId": 1,
    "episodeName": "teste",
    "episodeLength": "20:00",
    "episodeSynopsis": "teste",
    "episodeRealease": "2023-03-26T23:39:05.624Z",
    "seasonId": 1
  },
  "friendlyErrorMessage": null,
  "message": "Registro atualizado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

#### `DELETE /api/Episode/DeleteEpisode`
*Deletar um episódio pelo id do episódio e o id do anime*

>Parameter

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| EpisodeId     | query | integer(int32) |  Id do episódio.|
| AnimeId     | query | integer(int32) |  Id do anime.| 

*Exemplo de retorno:*
>Status code: 200

```json
{
  "data": null,
  "friendlyErrorMessage": null,
  "message": "Registro deletado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

## Genre
#### `GET /api/Genre/ListGenreByAnimeId`
*Listar todos os gêneros pelo anime id*

>Parameter

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| AnimeId     | query | integer(int32) |  Id do anime.| 

*Exemplo de retorno:*
>Status code: 200

```json
{
  "data": [
    {
      "genreId": 1,
      "genreName": "Aventura"
    },
    {
      "genreId": 2,
      "genreName": "Fantasia"
    },
    {
      "genreId": 3,
      "genreName": "Arte Marciais"
    },
    {
      "genreId": 7,
      "genreName": "teste"
    }
  ],
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |
| 404 | Not Found | Not Found | vmResult |

#### `GET /api/Genre/ListAllGenre`
*Listar todos os gêneros*
> Body parameter - No parameter

*Exemplo de retorno:*
>Status code: 200

```json
{
  "data": [
    {
      "genreId": 1,
      "genreName": "Aventura"
    },
    {
      "genreId": 2,
      "genreName": "Fantasia"
    },
    {
      "genreId": 3,
      "genreName": "Arte Marciais"
    },
    {
      "genreId": 7,
      "genreName": "teste"
    }
  ],
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |
| 404 | Not Found | Not Found | vmResult |

#### `PUT /api/Genre/UpdateGenre`
*Atualizar algum campo do gênero*

>Body parameter
```json
{
  "genreId": 1,
  "genreName": "Drama"
}
```

*Exemplo de retorno:*
>Status code: 200

```json
{
  "data": {
    "genreId": 7,
    "genreName": "teste2"
  },
  "friendlyErrorMessage": null,
  "message": "Registro atualizado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

#### `POST /api/Genre/InsertGenre`
*Inserir um novo gênero*

> Body parameter

```json
{
  "genreName": "teste"
}
```

*Exemplo de retorno*
>Status code: 200

```json
{
  "data": {
    "genreName": "teste"
  },
  "friendlyErrorMessage": null,
  "message": "Registro inserido com sucesso!",
  "stackTrace": null
}
```
| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

#### `DELETE /api/Genre/DeleteGenre`
*Deletar um gênero por id*

> Parameter

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| GenreId     | query | integer(int32) |  Id do gênero.                                                                              |

*Exemplo de retorno*
>Status code: 200

```json
{
  "data": null,
  "friendlyErrorMessage": null,
  "message": "Registro deletado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

## Season 

### `GET /api/Season/ListAllSeason`
*Listar todas as temporadas*

> Body parameter - No parameter

*Exemplo de retorno*
> Status code: 200

```json
{
  "data": [
    {
      "seasonId": 1,
      "seasonName": "Temporada 1"
    },
    {
      "seasonId": 2,
      "seasonName": "Temporada 1"
    }
  ],
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |
| 404 | Not Found | Not Found | vmResult |

### `GET /api/Season/ListSeasonByAnimeId`
*Listar temporada pelo id do anime*

> Parameter 

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| animeId     | query | integer(int32) |  Id do anime.                                                                              |

*Exemplo de retorno*

>Status code: 200

```json
{
  "data": [
    {
      "seasonId": 1,
      "seasonName": "Temporada 1"
    }
  ],
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |
| 404 | Not Found | Not Found | vmResult |

### `POST /api/Season/InsertSeason`
*Inserir uma nova temporada*

> Body parameter

```json
{
  "seasonName": "Temporada 3"
}
```

*Exemplo de retorno*

>Status code: 200

```json
{
  "data": {
    "seasonName": "Temporada 3"
  },
  "friendlyErrorMessage": null,
  "message": "Registro inserido com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

### `PUT /api/Season/UpdateSeason`
*Atualizar algum campo da temporada*

> Body parameter

```json
{
  "seasonId": 0,
  "seasonName": "string"
}
```

*Exemplo de retorno*
>Status code: 200

```json
{
  "data": {
    "seasonId": 3,
    "seasonName": "Temporada 3"
  },
  "friendlyErrorMessage": null,
  "message": "Registro atualizado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

### `DELETE /api/Season/DeleteSeason`
*Deletar uma temporada pelo id*

>Parameter 

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| animeId     | query | integer(int32) |  Id do anime.                                                                              |

*Exemplo de retorno*
>Status code: 200

```json
{
  "data": null,
  "friendlyErrorMessage": null,
  "message": "Registro deletado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

## Studio 

### `GET /api/Studio/ListAllStudio`
*Listar todos os estúdios*

>Body parameter - No Parameter

*Exemplo de retorno*
>Status code: 200

```json
{
  "data": [
    {
      "studioId": 1,
      "studioName": "Nippon Animation"
    },
    {
      "studioId": 2,
      "studioName": "Nippon Animation"
    }
  ],
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |
| 404 | Not Found | Not Found | vmResult |

### `POST /api/Studio/InsertStudio`
*Inserir um novo estúdio*

> Body parameter

```json
{
  "studioName": "string"
}
```

*Exemplo de retorno*
>Status code: 200

```json
{
  "data": {
    "studioName": "teste"
  },
  "friendlyErrorMessage": null,
  "message": "Registro inserido com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

### `PUT /api/Studio/UpdateStudio`
*Atualizar algum campo do estúdio.*

> Body parameter
```json
{
  "studioId": 3,
  "studioName": "teste2"
}
```

*Exemplo retorno*
>Status code:

```json
{
  "data": {
    "studioId": 3,
    "studioName": "teste2"
  },
  "friendlyErrorMessage": null,
  "message": "Registro atualizado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

### `DELETE /api/Studio/DeleteStudio`
*Deletar um estúdio por id.*

>Parameter 

| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| studioId     | query | integer(int32) |  Id do estúdio.                                                                              |

*Exemplo de retorno*

>Status code: 200

```json
{
  "data": null,
  "friendlyErrorMessage": null,
  "message": "Registro deletado com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

# Schemas
### vmResult
```json
{
  "data": {
    "title": "teste",
    "originalTitle": "teste",
    "synopsis": "teste",
    "realeaseYear": "2023-03-26T23:01:27.968Z",
    "studioId": 1
  },
  "friendlyErrorMessage": null,
  "message": "Registro inserido com sucesso!",
  "stackTrace": null
}
}

```

Definição da entidade de retorno.

### Propriedades

| Name            | Type                            | Required  | Description                                                                         |
| --------------- | ------------------------------- | -------- | --------------------------------------------------------------------------------------- |
| data              | object                   | true     | Objeto de retorno |
| friendlyErrorMessage              | string                   | true     | Mensagem de erro |
| message              | string                   | true     | Mensagem de retorno |
| stackTrace              | string                   | true     | Mensagem de erro (Exception) |





