# ploomesTest-API
>>REST Api desenvolvida para teste prático onde você pode visualizar, criar, atualizar e deletar items

Swagger endpoints: [SwaggerUI](https://prjanimetest.azurewebsites.net/swagger/index.html)
## Anime
#### `GET /api/Anime/api/Anime/ListAllAnimes`
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



