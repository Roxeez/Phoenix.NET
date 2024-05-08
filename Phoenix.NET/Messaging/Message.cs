﻿using Newtonsoft.Json;

namespace Phoenix.NET.Messaging;

public enum MessageType : byte
{
    PacketSend,
    PacketReceived,
    Attack,
    PlayerSkill,
    PlayerWalk,
    PetSkill,
    PartnerSkill,
    PetsWalk,
    PickUp,
    Collect,
    StartBot,
    StopBot,
    ContinueBot,
    LoadSettings,
    StartMinigameBot,
    StopMinigameBot,
    QueryPlayer,
    QueryInventory,
    QuerySkills,
    QueryMapEntities
}

public class Message
{
    [JsonProperty("type")]
    public MessageType Type { get; protected set; }

    public Message()
    {
        
    }

    public Message(MessageType type)
    {
        Type = type;
    }
}
