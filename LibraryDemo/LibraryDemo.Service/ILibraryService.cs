using LibraryDemo.DTO;
using System.Collections.Generic;
using System.ServiceModel;

namespace LibraryDemo.Service
{
    [ServiceContract]
    public interface ILibraryService
    {
        [OperationContract]
        List<TransactionTypeDTO> GetTransactionTypes();
    }
}
