using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockData
{
    public static class EntityData
    {
        public static CreateEntityParameter CreateValidEntityParameter()
        {
            return new CreateEntityParameter()
            {
                Name = "Sample Video",
                InputType = EntityInputTypes.S3Uiza,
                URL = ""
            };
        }

        public static CreateEntityParameter CreateMissingPropertyParameter()
        {
            return new CreateEntityParameter()
            {
            };
        }

        public static CreateEntityParameter CreateInValidEntityParameter()
        {
            return new CreateEntityParameter()
            {
                Name = string.Empty,
                InputType = EntityInputTypes.Ftp,
                URL = "http"
            };
        }
    }
}
