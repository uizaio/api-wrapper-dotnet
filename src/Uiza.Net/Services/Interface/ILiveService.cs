using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    ///
    /// </summary>
    public interface ILiveService :
        IBaseServices,
        ICreate<UizaData, CreateLiveParameter>,
        IRetrieve<UizaData, GetLiveParameter>,
        IUpdate<UizaData, UpdateLiveParameter>,
        IDelete<UizaData>
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        UizaData StartFeed(StartFeedParameter param);

        /// <summary>
        ///
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData GetView(string eventId);

        /// <summary>
        ///
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData StopFeed(string eventId);

        /// <summary>
        ///
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        UizaData ConvertToVOD(string recordId);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData ListRecorded(string eventId);
    }
}