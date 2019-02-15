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

        public static RetrieveListEntitiesParameter ListValidEntityParameter()
        {
            return new RetrieveListEntitiesParameter();
        }

        public static UpdateEntityParameter UpdateValidEntityParameter()
        {
            return new UpdateEntityParameter()
            {
                Id = "2e173ee3-be45-46bd-a355-c9182a2a41ec",
                Name = "Sample update",
                Description = "Description update",
                ShortDescription = "ShortDescription update",
                Poster = "/example.com/updatePoster",
                Thumbnail = "/example.com/updateThumbnail"
            };
        }

        public static UpdateEntityParameter UpdateInValidEntityParameter()
        {
            return new UpdateEntityParameter()
            {
                Name = "Sample update",
                Description = "Description update",
                ShortDescription = "ShortDescription update",
                Poster = "/example.com/updatePoster",
                Thumbnail = "/example.com/updateThumbnail"
            };
        }
    }
}