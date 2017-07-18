using AutoMapper;
using LibraryDemo.DTO;
using LibraryDemo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.Service
{
    [AutoMapServiceBehavior]
    public class LibraryService : ILibraryService
    {
        public List<TransactionTypeDTO> GetTransactionTypes()
        {
            List<TransactionTypeDTO> transactionTypes = new List<TransactionTypeDTO>();

            try
            {
                using (LibraryDemoEntities context = new LibraryDemoEntities())
                {
                    var allTransactionTypes = context.LibraryTransactionTypes.ToList();
                    transactionTypes = Mapper.Map<List<LibraryTransactionType>, List<TransactionTypeDTO>>(allTransactionTypes);
                }
            }
            catch (Exception ex)
            {
                // TODO - Implement logging
            }

            return transactionTypes;
        }
    }
}
