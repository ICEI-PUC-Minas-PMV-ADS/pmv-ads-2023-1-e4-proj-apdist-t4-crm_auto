using CRMobil.Entities.Clientes;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CRMobil.Data.Mapper
{
    public class ClienteMapper
    {
        [BsonId]
        [BsonElement("id_cliente")]
        public string IdCliente { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [BsonElement("nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Número do documento é obrigatório")]
        [BsonElement("cpf_cnpj")]
        public string CpfCnpj { get; set; }

        [BsonElement("cep")]
        public string Cep { get; set; }

        [BsonElement("logradouro")]
        public string Logradouro { get; set; }

        [BsonElement("numero")]
        public string Numero { get; set; }

        [BsonElement("complemento")]
        public string Complemento { get; set; }

        [BsonElement("bairro")]
        public string Bairro { get; set; }

        [BsonElement("cidade")]
        public string Cidade { get; set; }

        [BsonElement("uf")]
        public string Uf { get; set; }

        [BsonElement("telefone_residencial")]
        public string TelefoneResidencial { get; set; }

        [Required(ErrorMessage = "O número do telefone celular é obrigatório")]
        [BsonElement("telefone_celular")]
        public string TelefoneCelular { get; set; }

        [Required(ErrorMessage = "Informe um e-mail válido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        [BsonElement("email")]
        public string Email { get; set; }

        public virtual IEnumerable<ClienteVeiculo> ClienteVeiculos { get; set; }
    }
}
