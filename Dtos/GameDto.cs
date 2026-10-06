namespace Gamestore.APi.Dtos;

// a dto is a contract between the client and server since it represents
//a shared aggrement about how datra will be tranfered and used

public record class GameDto
(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate 
    
);