using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CategoryViewModel, CreateCategoryCommand>()
                .ConstructUsing(c => new CreateCategoryCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}
