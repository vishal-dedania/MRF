using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using MRF.Web.Infrastructure.Mapping;

namespace MRF.Web
{
    public static class AutoMapperConfig
    {
        public static void Execute()
        {
            var types = Assembly.GetExecutingAssembly().GetExportedTypes();
            LoadStandardMapping(types);
        }

        private static void LoadStandardMapping(IEnumerable<Type> types)
        {
            var maps = (from t in types
                from i in t.GetInterfaces()
                where i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>) &&
                      !t.IsAbstract &&
                      !t.IsInterface
                select new
                {
                    Source = i.GetGenericArguments()[0],
                    Destination = t
                }).ToArray();

            
            foreach (var map in maps)
            {
                Mapper.Initialize(cfg => cfg.CreateMap(map.Source, map.Destination).ReverseMap());
            }
        }
    }
}