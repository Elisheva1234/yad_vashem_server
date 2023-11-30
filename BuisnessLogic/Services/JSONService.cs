using AutoMapper;
using BuisnessLogic.DTO;
using DataAccess.Models;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.Services
{
    public class JSONService : IJSONService
    {
        IJSONRepository repository;
        IMapper mapper;
        public JSONService(IJSONRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public void AddImages(ImageModelDTO images)
        {
            repository.AddImages(mapper.Map<ImageModel>(images));
        }

        public CollectionDetails GetTitelOfImg(string collectionSymbolization)
        {
            return repository.GetTitelOfImg(collectionSymbolization);
        }


    }
}
