﻿using System.Text.Json;

namespace AcFunDanmuSongRequest.Platform.Interfaces
{
    interface IEncodedResponse
    {
        public static readonly JsonSerializerOptions Options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        public string Decode();
    }
}
