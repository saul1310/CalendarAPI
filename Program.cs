 
 
using Gamestore.APi.Dtos;

var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();


List<string> dailyReport = [
     "its gonna be good today"






    ];

List<GameDto> games = [
    //adding M to the end of a integer tells the compiler to treat it as a decimal
    new (
        1,
    "Street Fighter II",
    "Fighting",
    19.99M,
    new DateOnly(1992,7,15)
    ),

    new(
        2,
        "Skyrim",
        "RPG",
        19.99M,
        new DateOnly(2011,11,11)




    ),
    new(
        3,
        "Resident Evil II",
        "Horror",
        19.99M,
        new DateOnly(1998,1,21)



    )

];
//GET /games 
 
app.MapGet("/games", () => games);


//GET Daily Tasks

app.MapGet("/dailyreport", () => dailyReport);


//GET /games/1


app.MapGet("/games/{id}", (int id) => games.Find(game => game.Id == id))
    .WithName("GetGame");

//POST /games 
app.MapPost("/games",(CreateGameDto newGame) =>
{
    GameDto game = new(
        games.Count +1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate
    );
    
    games.Add(game);
    return Results.CreatedAtRoute("GetGame",new {id = game.Id},game);


}



);

//endpoint to update a game 


app.MapPut("/games/{id}",(int id, UpdateGameDto updatedGame ) => {
    var index = games.FindIndex(game => game.Id == id );

    games[index] = new GameDto(
    
        id,
        updatedGame.Name,
        updatedGame.Genre,
        updatedGame.Price,
        updatedGame.ReleaseDate
    );

    //convetion for update is to return  NoContent? what is that

    return Results.NoContent();
    

        
    
    


});
 

app.Run();

 