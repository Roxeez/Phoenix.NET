﻿using Newtonsoft.Json;

namespace Phoenix.NET.Messaging.Movement;

public class PetsWalk : Message
{
    [JsonProperty("x")]
    public required int X { get; init; }
    
    [JsonProperty("y")]
    public required int Y { get; init; }

    public PetsWalk()
    {
        Type = MessageType.PetsWalk;
    }
}