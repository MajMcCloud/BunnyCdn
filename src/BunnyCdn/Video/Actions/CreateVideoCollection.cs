﻿using System.Text.Json.Serialization;

namespace BunnyCdn;

public sealed class CreateVideoCollection
{
    public CreateVideoCollection(long libraryId, string name)
    {
        LibraryId = libraryId;
        Name = name;
    }

    [JsonIgnore]
    public long LibraryId { get; }

    [JsonPropertyName("name")]
    public string Name { get; }
}