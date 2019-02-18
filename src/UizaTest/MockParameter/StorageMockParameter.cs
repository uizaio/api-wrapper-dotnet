using System;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockParameter
{
    public static class StorageMockParameter
    {
        public static CreateStorageParameter CreateValidStorageParameter()
        {
            return new CreateStorageParameter()
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

        public static CreateStorageParameter CreateInValidStorageParameter()
        {
            return new CreateStorageParameter()
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
                AwsAccessKey = "ASIAV*******GPHO2DTZ",
                AwsSecretKey = "dp****cx2mE2lZxsSq7kV++vWSL6RNatAhbqc",
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