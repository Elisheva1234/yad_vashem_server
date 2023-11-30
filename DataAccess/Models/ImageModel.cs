using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ImageModel
    {
        public string collectionSymbolization { get; set; }
        public string title { get; set; }
        public string itemId { get; set; }
        public string imagePath { get; set; }
        public string? BackOfImage {  get; set; }
        public string imgNumber { get; set; }
    }
}
