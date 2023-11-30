using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repositories
{
    public interface IJSONRepository
    {
        public void AddImages(ImageModel images);
        public CollectionDetails GetTitelOfImg(string collection);
    }
}
