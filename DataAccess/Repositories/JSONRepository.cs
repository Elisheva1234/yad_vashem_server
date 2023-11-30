using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using DataAccess.Models;
using Microsoft.Extensions.Logging;

namespace DataAccess.Repositories
{
    public class JSONRepository : IJSONRepository
    {
        ILogger<ImageModel> logger;
        ILogger<CollectionDetails> logger1;

        public JSONRepository(ILogger<ImageModel> logger, ILogger<CollectionDetails> logger1)
        {
            this.logger = logger;
            this.logger1 = logger1;
        }

        public void AddImages(ImageModel image)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(image);
                File.WriteAllText(image.imagePath+".json", jsonData);
                CollectionDetails collection = new CollectionDetails() { collctionName = image.title, collectionSymbolization = image.collectionSymbolization, numOfImg = image.imgNumber };
                string json = JsonConvert.SerializeObject(collection);
                File.WriteAllText("images/"+image.collectionSymbolization+ "/collectionDetails.json",json);
            }
            catch (Exception ex)
            {
                logger.LogError("Error in AddImages " + ex.Message);
            }
        }

        public CollectionDetails GetTitelOfImg(string collection)
        {
            try
            {
                if (File.Exists("images/" + collection + "/collectionDetails.json"))
                {
                    string jsonData = File.ReadAllText("images/" + collection + "/collectionDetails.json");
                    return JsonConvert.DeserializeObject<CollectionDetails>(jsonData);
                    
                }
                return new CollectionDetails() { collctionName= "There is no such collection", collectionSymbolization="",numOfImg="00000" };

            }
            catch (Exception ex)
            {
                logger1.LogError("Error in GetTitelOfImg " + ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
