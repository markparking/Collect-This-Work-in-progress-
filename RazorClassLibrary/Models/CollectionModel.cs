using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorClassLibrary.Models;


namespace RazorClassLibrary.Models
{
    public class CollectionModel
    {
        public int CollectionId { get; set; }
        public string collectionItem { get; set; }
        public List<CollectionModel> Items { get; set; } = new List<CollectionModel>();
        public int ItemId { get; set; }
        public string ItemName
        {
            get; set;
        }
    }
}
