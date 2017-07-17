using AutoMapper;
using LibraryDemo.LibraryService;
using LibraryDemo.Model;
using System;

namespace LibraryDemo
{
    public class Bootstrapper
    {
        public static void ConfigureAutoMapping()
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<TransactionType, TransactionTypeModel>();
                });

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<TransactionType, TransactionTypeModel>();
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
