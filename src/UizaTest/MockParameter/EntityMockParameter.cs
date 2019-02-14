using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockData
{
    public static class EntityMockParameter
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

        public static CreateEntityParameter CreateInValidEntityParameter()
        {
            return new CreateEntityParameter()
            {
                InputType = EntityInputTypes.Ftp,
                URL = "http"
            };
        }
    }
}
