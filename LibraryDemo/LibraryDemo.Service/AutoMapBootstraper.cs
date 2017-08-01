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
                    cfg.CreateMap<Book, BookDTO>(); // This is not used at present
                });

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Book, BookDTO>();
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
