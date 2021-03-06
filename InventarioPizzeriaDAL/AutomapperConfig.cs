﻿using AutoMapper;
using InventarioPizzeriaDAL.DTO;
using InventarioPizzeriaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL
{
    public static class AutomapperConfig
    {
        public static void MapperConfig()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<ProductDTO, Product>();

                cfg.CreateMap<Dough, DoughDTO>();
                cfg.CreateMap<DoughDTO, Dough>();

                cfg.CreateMap<Report, ReportDTO>();
                cfg.CreateMap<ReportDTO, Report>();

                cfg.CreateMap<Shop, ShopDTO>();
                cfg.CreateMap<ShopDTO, Shop>();

                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
            });
        }
    }
}
