namespace Gamestore.APi.Dtos;

// a dto is a contract between the client and server since it represents
//a shared aggrement about how data will be tranfered and used

public record class EventDTO
(

    string EventName,
    DateOnly Date,
    TimeOnly StartTime,
    TimeOnly EndTime
);