using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepo, IMediatorHandler bus, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _bus = bus;
            _mapper = mapper;
        }

        public void Create(CategoryViewModel categoryViewModel)
        {
            //CreateCategoryCommand createCategoryCommand = new(
            //        categoryViewModel.Name,
            //        categoryViewModel.Description,
            //        categoryViewModel.ImageUrl
            //    );

            _bus.SendCommand(_mapper.Map<CreateCategoryCommand>(categoryViewModel));

        }

        public CategoryViewModel GetCategories() => new() { Categories = _categoryRepo.GetCategories() };
    }
}
