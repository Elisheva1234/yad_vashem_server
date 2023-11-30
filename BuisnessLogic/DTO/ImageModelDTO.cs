using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.DTO
{
    public class ImageModelDTO
    {
        public string collectionSymbolization { get; set; }
        public string title { get; set; }
        public string itemId { get; set; }
        public string imagePath { get; set; }
        public string? BackOfImage { get; set; }
        public string imgNumber { get; set; }
        public bool back {  get; set; }
        public bool save {  get; set; }
    }
}
