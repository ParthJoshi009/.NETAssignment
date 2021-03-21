using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessObjects;
using DataAccess;

namespace BusinessLogic
{
    public static class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }
        public static void init()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Dealer, tblDealer>();
                cfg.CreateMap<Customer, tblCustomer>();
                cfg.CreateMap<Login, tblLogin>();
                cfg.CreateMap<Mechanic, tblMechanic>();
                cfg.CreateMap<Register,tblRegister>();
                cfg.CreateMap<Service,tblService>();
                cfg.CreateMap<Vehicle, tblVehicle>();
            });
            Mapper = config.CreateMapper();
        }
    }
}
