using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    internal class LiveServices : Service, ILiveService
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Create(CreateLiveParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.CREATE);
            return this.PostRequest<UizaData>(Constants.ApiAction.LIVE, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Update(UpdateLiveParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.UPDATE);
            return this.PutRequest<UizaData>(Constants.ApiAction.LIVE, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public UizaData ListRecorded(string eventId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.LIVE_DVR, new RetrieveItemParameter()
            {
                Id = eventId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.LIST_ALL_RECORDED_FILES)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Retrieve(GetLiveParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.RETRIEVE);
            return this.GetRequest<UizaData>(Constants.ApiAction.LIVE, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="recordId">Identifier of record (get from list record)</param>
        /// <returns></returns>
        public UizaData Delete(string recordId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.LIVE_DVR, new RetrieveItemParameter()
            {
                Id = recordId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.DELETE_A_RECORD_FILE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public UizaData GetView(string eventId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.LIVE, new RetrieveItemParameter()
            {
                Id = eventId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.RETRIEVE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData StartFeed(StartFeedParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.START_A_LIVE_FEED);
            return this.PostRequest<UizaData>(Constants.ApiAction.LIVE_FEED, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public UizaData StopFeed(string eventId)
        {
            return this.PutRequest<UizaData>(Constants.ApiAction.LIVE_FEED, new RetrieveItemParameter()
            {
                Id = eventId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.STOP_A_LIVE_FEED)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        public UizaData ConvertToVOD(string recordId)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.LIVE_VOD, new RetrieveItemParameter()
            {
                Id = recordId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE_STREAMING.STOP_A_LIVE_FEED)
            });
        }
    }
}