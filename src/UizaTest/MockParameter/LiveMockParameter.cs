using System;
using System.Collections.Generic;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockParameter
{
    public static class LiveMockParameter
    {
        public static CreateLiveParameter CreateLiveStreamingParameter()
        {
            return new CreateLiveParameter()
            {
                Name = Guid.NewGuid().ToString(),
                Mode = "push",
                Encode = EncodeTypes.Encode,
                Dvr = DvrTypes.NoRecord,
                LinkStream = new List<string>() { "https://playlist.m3u8" },
                ResourceMode = ResourceModes.Single
            };
        }

        public static UpdateLiveParameter UpdateLiveStreamingParameter()
        {
            return new UpdateLiveParameter()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString(),
                Dvr = DvrTypes.NoRecord,
                Mode = "push",
                Encode = EncodeTypes.Encode,
                ResourceMode = ResourceModes.Single
            };
        }
    }
}