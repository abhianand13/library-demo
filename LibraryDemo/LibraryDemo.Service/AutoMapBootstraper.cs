using AutoMapper;
using LibraryDemo.DTO;
using LibraryDemo.DAO;
using System;

namespace LibraryDemo.Service
{
    public class AutoMapBootstraper
    {
        public static void InitializeMap()
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<LibraryTransactionType, TransactionTypeDTO>();
                });

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<LibraryTransactionType, TransactionTypeDTO>();
                });
                config.AssertConfigurationIsValid();
            }
            catch (Exception ex)
            {
                // TODO - Log error and exit application
            }
        }
    }
}
