using AutoMapper;
using Catering.Data.Models;
using Catering.Data.Repositories;
using Catering.Domain.Models;
using System.Collections.Generic;

namespace Catering.Domain.Services
{
    public class ChefService
    {
        private readonly ChefRepository _chefRepository;
        private readonly IMapper _mapper;

        public ChefService()
        {
            _chefRepository = new ChefRepository();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<UserModel, User>().ReverseMap();
                cfg.CreateMap<ChefModel, Chef>().ReverseMap();
                cfg.CreateMap<CateringOrderModel, CateringOrder>().ReverseMap();
            });
            _mapper = new Mapper(mapperConfig);

        }

        public ChefModel CreateChef(ChefModel model)
        {

            var chef = _mapper.Map<Chef>(model);

            var addedChef = _chefRepository.Create(chef);

            return _mapper.Map<ChefModel>(addedChef);

        }

        public IEnumerable<ChefModel> GetAll()
        {
            var models = _chefRepository.GetAll();
            return _mapper.Map<IEnumerable<ChefModel>>(models);
        }

        public bool DeleteChef(int id)
        {
            return _chefRepository.Delete(id);
        }

        public ChefModel UpdateChef(ChefModel model)
        {
            var chef = _mapper.Map<Chef>(model);

            var updatedChef = _chefRepository.Update(chef);

            return _mapper.Map<ChefModel>(updatedChef);
        }

        public ChefModel GetById(int id)
        {
            var model = _chefRepository.GetById(id);

            return _mapper.Map<ChefModel>(model);
        }
    }
}
