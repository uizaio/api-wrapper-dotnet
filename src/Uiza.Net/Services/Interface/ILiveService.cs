using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Live Service Interface
    /// </summary>
    public interface ILiveService :
        IBaseServices,
        ICreate<UizaData, CreateLiveParameter>,
        IRetrieve<UizaData, string>,
        IUpdate<UizaData, BaseParameter>,
        IDelete<UizaData>
    {
        /// <summary>
        /// Start a live feed
        /// These API use to start a live event that has been create success. 
        /// The Live channel minute start count whenever the event start success
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData StartFeed(string eventId);

        /// <summary>
        /// Get view of live feed
        /// This API use to get a live view status . 
        /// This view only show when event has been started and being processing.
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData GetView(string eventId);

        /// <summary>
        /// Stop a live feed, stop live event
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        UizaData StopFeed(string eventId);

        /// <summary>
        /// Convert into VOD
        /// Convert recorded file into VOD entity. After converted, your file can be stream via Uiza's CDN.
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        UizaData ConvertToVOD(string recordId);

        /// <summary>
        /// List all recorded files
        /// Retrieves list of recorded file after streamed (only available when your live event has turned on Record feature)
        /// </summary>
        /// <returns></returns>
        UizaData ListRecorded();
    }
}