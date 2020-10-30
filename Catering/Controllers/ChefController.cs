using AutoMapper;
using Catering.Domain.Models;
using Catering.Domain.Services;
using Catering.Models.PostModels;
using Catering.Models.ViewModels;
using System.Collections.Generic;

namespace Catering.Controllers
{
    public class ChefController
    {
        private readonly ChefService _chefService;
        private readonly IMapper _mapper;

        public ChefController()
        {
            _chefService = new ChefService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<UserPostModel, UserModel>();
                cfg.CreateMap<ChefPostModel, ChefModel>();
                cfg.CreateMap<CateringOrderPostModel, CateringOrderModel>();
                cfg.CreateMap<UserModel, UserViewModel>();
                cfg.CreateMap<ChefModel, ChefViewModel>();
                cfg.CreateMap<CateringOrderModel, CateringOrderViewModel>();
            });
            _mapper = new Mapper(mapperConfig);

        }

        public ChefViewModel CreateChef(ChefPostModel model)
        {

            var chef = _mapper.Map<ChefModel>(model);

            var addedChef = _chefService.CreateChef(chef);

            return _mapper.Map<ChefViewModel>(addedChef);

        }

        public IEnumerable<ChefViewModel> GetAll()
        {
            var models = _chefService.GetAll();
            return _mapper.Map<IEnumerable<ChefViewModel>>(models);
        }

        public bool DeleteChef(int id)
        {
            return _chefService.DeleteChef(id);
        }

        public ChefViewModel UpdateChef(ChefPostModel model)
        {
            var chef = _mapper.Map<ChefModel>(model);

            var updatedChef = _chefService.UpdateChef(chef);

            return _mapper.Map<ChefViewModel>(updatedChef);
        }

        public ChefViewModel GetById(int id)
        {
            var model = _chefService.GetById(id);

            return _mapper.Map<ChefViewModel>(model);
        }
    }
}
