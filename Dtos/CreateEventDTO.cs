namespace Gamestore.APi.Dtos;

public record CreateEventDTO(
    string EventName,
    DateOnly Date,
    TimeOnly StartTime,
    TimeOnly EndTime
    );