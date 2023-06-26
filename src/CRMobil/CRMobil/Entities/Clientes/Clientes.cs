using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMobil.Entities.Clientes
{
    public class Clientes
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [Display(Name = "id_cliente")]
        public string IdCliente { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3, ErrorMessage = "A quantidade mínima é 3 caracteres para o nome")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage =
            "Números e caracteres especiais não são permitidos no nome.")]
        [Column("nome_cliente")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "Número do documento é obrigatório")]
        [MinLength(11)]
        [MaxLength(14)]
        [Column("cnpj_cpf")]
        public string CnpjCpf { get; set; }

        [Column("cnpj_ou_cpf")]
        public string CnpjOuCpf { get; set; }

        [Column("apelido")]
        public string Apelido { get; set; }

        [Column("data_nascimento")]
        public string DataNascimento { get; set; }

        [Column("data_cadastro")]
        public string DataCadastro { get; set; }

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O CEP é obrigatório")]
        [Column("cep")]
        public string Cep { get; set; }

        [Column("logradouro")]
        public string Logradouro { get; set; }

        [Column("numero")]
        public string Numero { get; set; }

        [Column("complemento")]
        public string Complemento { get; set;}

        [Column("bairro")]
        public string Bairro { get; set;}

        [Column("cidade")]
        public string Cidade { get; set;}

        [Column("estado")]
        public string Estado { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O número do telefone celular é obrigatório")]
        [Column("celular")]
        public string Celular { get; set;}

        [Required(ErrorMessage = "Informe um e-mail válido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido")]
        [Column("email_nf")]
        public string EmailNf { get; set; }

        [Column("excluido")]
        public string Excluido { get; set; }

        [Column("cliente_veiculos")]
        public virtual IEnumerable<ClienteVeiculo> ClienteVeiculos { get; set; }

        //public static implicit operator Clientes(void v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
