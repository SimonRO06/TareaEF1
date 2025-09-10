using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class DetailsFavorites
    {
        // Table name is "details_favorites"
        public int Id { get; set; }
        public int FavoriteId { get; set; } // Is INT in DB and is foreign key to favorites table and column name is "favorite_id"
        public int ProductId { get; set; } // Is INT in DB and is foreign key to products table and column name is "product_id"
    }
}