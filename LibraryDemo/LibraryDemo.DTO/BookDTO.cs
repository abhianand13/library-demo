using System.Runtime.Serialization;

namespace LibraryDemo.DTO
{
    [DataContract]
    public class BookDTO
    {
        [DataMember]
        public string Isbn { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string AuthorName { get; set; }
    }
}
