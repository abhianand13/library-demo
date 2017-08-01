using System.Runtime.Serialization;

namespace LibraryDemo.DTO
{
    [DataContract]
    public class AuthorDTO
    {
        [DataMember]
        public string Name { get; set; }
    }
}
