using System.Runtime.Serialization;

namespace ToSoftware.Shop.Accounts.Api.Messages.Requests
{
    [DataContract]
    public class LoginRequestMessage
    {
        [DataMember]
        public string Identification { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}