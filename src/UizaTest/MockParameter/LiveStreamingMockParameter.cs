using System;
using System.Collections.Generic;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockParameter
{
    public static class LiveStreamingMockParameter
    {
        public static CreateLiveParameter CreateLiveStreamingParameter()
        {
            return new CreateLiveParameter()
            {
                Name = Guid.NewGuid().ToString(),
                Mode = "push",
                Encode = EncodeTypes.Encode,
                Drv = DvrTypes.NoRecord,
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
                Drv = DvrTypes.NoRecord,
                Mode = "push",
                Encode = EncodeTypes.Encode,
                ResourceMode = ResourceModes.Single
            };
        }
    }
}