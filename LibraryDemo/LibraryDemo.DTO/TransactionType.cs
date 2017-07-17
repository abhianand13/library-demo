﻿using System.Runtime.Serialization;

namespace LibraryDemo.DTO
{
    [DataContract]
    public class TransactionType
    {
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
