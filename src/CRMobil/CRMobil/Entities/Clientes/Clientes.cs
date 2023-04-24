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

        //[Required(ErrorMessage = "O nome é obrigatório")]
        [BsonElement("nome_cliente")]
        public string Nome_Cliente { get; set; }

        //[Required(ErrorMessage = "Número do documento é obrigatório")]
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

        //[BsonElement("id_usuario_cad")]
        //public string Id_Usuario_Cad { get; set; }

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

        //[Required(ErrorMessage = "O número do telefone celular é obrigatório")]
        [BsonElement("celular")]
        public string Celular { get; set;}

        //[Required(ErrorMessage = "Informe um e-mail válido")]
        //[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        [BsonElement("email_nf")] 
        public string Email_Nf { get; set; }
        
        [BsonElement("Excluido")]
        public string Excluido { get; set; }

        //[BsonElement("id_clie_veiculo")]
        //public string Id_Cli_veiculo { get; set; }

        //[BsonElement("id_veiculo")]
        //public string Id_Veiculo { get; set; }

        //[BsonElement("veiculo_atual")]
        //public string Veiculo_Atual { get; set; }

        public virtual IEnumerable<ClienteVeiculo> ClienteVeiculos { get; set; }
    }
}
