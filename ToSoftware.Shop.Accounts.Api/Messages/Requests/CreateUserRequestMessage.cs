using System.Runtime.Serialization;

namespace ToSoftware.Shop.Accounts.Api.Messages.Requests
{
    [DataContract]
    public class CreateUserRequestMessage
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Identification { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}