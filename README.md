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

#### `GET /api/Anime/ListAllAnimesById`
*Listar anime pelo id do anime e do id do episódio.*

> Body parameter 

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
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |

#### `POST /api​/Anime​/InsertAnimeGenre`
*Inserir um gênero para um anime.*

> Body parameter 

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
*Deleta o anime pelo seu id.*

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



