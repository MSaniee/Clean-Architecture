using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new(cfg =>
            {
                cfg.AddProfile(new DomainToViewModelProfile());
                cfg.AddProfile(new ViewModelToDomainProfile());
            });
        }
    }
}
