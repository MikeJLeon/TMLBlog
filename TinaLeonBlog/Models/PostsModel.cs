using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TinaLeonBlog
{
    public class PostsModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string Summary { get; set; }

        public string PropertyType { get; set; }

        public string BedType { get; set; }
    }
}
