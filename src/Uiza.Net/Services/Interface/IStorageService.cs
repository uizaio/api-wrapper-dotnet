﻿using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    ///
    /// </summary>
    public interface IStorageService : IBaseServices,
        IAdd<UizaData, AddStorageParameter>,
        IRetrieve<UizaData>,
        IUpdate<UizaData, UpdateStorageParameter>,
        IRemove<UizaData>
    {
    }
}