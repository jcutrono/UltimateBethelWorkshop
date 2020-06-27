using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CovidWeb
{
    public class Location
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
        
        [BsonRepresentation(BsonType.String)]
        public string Name {get; set;}

        [BsonRepresentation(BsonType.String)]
        public string State { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string Href { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string Address { get; set; }

        [BsonRepresentation(BsonType.String)]
        public string Phone { get; set; }
        
    }
}