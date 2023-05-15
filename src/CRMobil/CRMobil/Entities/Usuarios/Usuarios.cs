using Microsoft.AspNetCore.Authorization;
using CRMobil.Entities.Usuarios;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CRMobil.Entities.Usuarios
{
    public class Usuarios
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [Display(Name = "id_usuario")]
        public string Id_Usuario { get; set; }

        [BsonElement("nome_usuario")]
        public string Nome_Usuario { get; set; }

        [BsonElement("senha")]
        public string Senha { get; set; }

        [BsonElement("tipo_usuario")]
        public string Tipo_Usuario { get; set; }
    }
}
