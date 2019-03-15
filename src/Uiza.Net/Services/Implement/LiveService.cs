using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    internal class LiveService : Service, ILiveService
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Create(CreateLiveParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE.CREATE);
            return this.PostRequest<UizaData>(Constants.ApiAction.LIVE, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Update(BaseParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE.UPDATE);
            return this.PutRequest<UizaData>(Constants.ApiAction.LIVE, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public UizaData ListRecorded()
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.LIVE_RECORDED, new BaseParameter()
            {
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE.LIST_ALL_RECORDED_FILES)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public UizaData Retrieve(string eventId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.LIVE, new RetrieveItemParameter()
            {
                Id = eventId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE.RETRIEVE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="recordId">Identifier of record (get from list record)</param>
        /// <returns></returns>
        public UizaData Delete(string recordId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.LIVE_RECORDED, new RetrieveItemParameter()
            {
                Id = recordId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE.DELETE_A_RECORD_FILE)
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
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE.RETRIEVE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public UizaData StartFeed(string eventId)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.LIVE_FEED, new RetrieveItemParameter()
            {
                Id = eventId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE.START_A_LIVE_FEED)
            });
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
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE.STOP_A_LIVE_FEED)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        public UizaData ConvertToVOD(string recordId)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.LIVE_CONVERT_VOD, new RetrieveItemParameter()
            {
                Id = recordId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.LIVE.STOP_A_LIVE_FEED)
            });
        }
    }
}