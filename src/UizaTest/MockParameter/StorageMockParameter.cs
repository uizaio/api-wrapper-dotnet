using System;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockParameter
{
    public static class StorageMockParameter
    {
        public static AddStorageParameter CreateValidStorageParameter()
        {
            return new AddStorageParameter()
            {
                Name = string.Format("Storage name {0}", Guid.NewGuid().ToString()),
                Host = "ftp-example.uiza.io",
                Description = "FTP of Uiza, use for transcode",
                StorageType = StorageInputTypes.Ftp,
                UserName = "uiza",
                Password = "=59x@LPsd+w7qW",
                Port = 21
            };
        }

        public static AddStorageParameter CreateInValidStorageParameter()
        {
            return new AddStorageParameter()
            {
            };
        }

        public static UpdateStorageParameter CreateValidUpdateStorageParameter()
        {
            return new UpdateStorageParameter()
            {
                Id = Guid.NewGuid().ToString(),
                Name = string.Format("Storage name {0}", Guid.NewGuid().ToString()),
                StorageType = StorageInputTypes.S3,
            };
        }

        public static UpdateStorageParameter CreateInValidUpdateStorageParameter()
        {
            return new UpdateStorageParameter()
            {
                Name = string.Format("Storage name {0}", Guid.NewGuid().ToString()),
            };
        }
    }
}