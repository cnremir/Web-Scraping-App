﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AnahtarKelime
    {
        [BsonId]
        public ObjectId anahtarKelimeId { get; set; }
        public string kelimeAdi { get; set; }
    }
}
