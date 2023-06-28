using CRMobil.Entities.Clientes;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CRMobil.Entities.Cliente
{
    public class Clientes
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [Display(Name = "id_cliente")]
        public string Id_Cliente { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3, ErrorMessage = "A quantidade mínima é 3 caracteres para o nome")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        [BsonElement("nome_cliente")]
        public string Nome_Cliente { get; set; }

        [Required(ErrorMessage = "Número do documento é obrigatório")]
        [MinLength(11)]
        [MaxLength(14)]
        [BsonElement("cnpj_cpf")]
        public string Cnpj_Cpf { get; set; }

        [BsonElement("cnpj_ou_cpf")]
        public string Cnpj_Ou_Cpf { get; set; }

        [BsonElement("apelido")]
        public string Apelido { get; set; }

        [BsonElement("data_nascimento")]
        public string Data_Nascimento { get; set; }

        [BsonElement("data_cadastro")]
        public string Data_Cadastro { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório")]
        [BsonElement("cep")]
        public string Cep { get; set; }

        [BsonElement("logradouro")]
        public string Logradouro { get; set; }

        [BsonElement("numero")]
        public string Numero { get; set; }

        [BsonElement("complemento")]
        public string Complemento { get; set;}

        [BsonElement("bairro")]
        public string Bairro { get; set;}

        [BsonElement("cidade")]
        public string Cidade { get; set;}

        [BsonElement("estado")]
        public string Estado { get; set; }

        [BsonElement("telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O número do telefone celular é obrigatório")]
        [BsonElement("celular")]
        public string Celular { get; set;}

        [Required(ErrorMessage = "Informe um e-mail válido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        [BsonElement("email_nf")]
        public string Email_Nf { get; set; }

        [BsonElement("excluido")]
        public string Excluido { get; set; }

        //[BsonElement("id_clie_veiculo")]
        //public string Id_Cli_veiculo { get; set; }

        //[BsonElement("id_veiculo")]
        //public string Id_Veiculo { get; set; }

        //[BsonElement("veiculo_atual")]
        //public string Veiculo_Atual { get; set; }

        [BsonElement("clienteVeiculos")]
        public virtual IEnumerable<ClienteVeiculo> ClienteVeiculos { get; set; }

        //public static implicit operator Clientes(void v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
