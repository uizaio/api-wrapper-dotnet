using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    internal class UserService : Service, IUserService
    {
        public UizaData Create(CreatUserParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.USER.CREATE);
            return this.PostRequest<UizaData>(Constants.ApiAction.USER, param);
        }

        public UizaData Retrieve(string userId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.USER, new RetrieveItemParameter()
            {
                Id = userId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.USER.RETRIEVE)
            });
        }

        public UizaData List()
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.USER, new RetrieveItemParameter()
            {
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.USER.RETRIEVE)
            });
        }

        public UizaData Update(UpdateUserParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.USER.UPDATE);
            return this.PutRequest<UizaData>(Constants.ApiAction.USER, param);
        }

        public UizaData Delete(string userId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.USER, new RetrieveItemParameter()
            {
                Id = userId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.USER.DELETE)
            });
        }

        public UizaData ChangePassword(ChangePasswordParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.USER.CHANGE_PASSWORD);
            return this.PostRequest<UizaData>(Constants.ApiAction.USER_CHANGE_PASSWORD, param);
        }

        public UizaData Logout()
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.USER_LOGOUT, new BaseParameter()
            {
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.USER.LOGOUT)
            });
        }
    }
}