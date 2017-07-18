using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemo.DTO
{
    [DataContract]
    public class AuthorDTO
    {
        [DataMember]
        public string Name { get; set; }
    }
}
