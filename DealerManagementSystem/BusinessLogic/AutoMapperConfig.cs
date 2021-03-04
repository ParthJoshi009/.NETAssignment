using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BusinessLogic
{
    public static class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }
        public static void init()
        {
            var config = new MapperConfiguration(cfg => 
            cfg.CreateMap<>(BusinessObjects.Dealer,DataAccess.tblDealer)
            );
            Mapper = config.CreateMapper();
        }
    }
}
