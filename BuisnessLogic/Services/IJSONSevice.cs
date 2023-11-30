using BuisnessLogic.DTO;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.Services
{
    public interface IJSONService
    {    
        public void AddImages(ImageModelDTO images);
        public CollectionDetails GetTitelOfImg(string collectionSymbolization);
    }
}
