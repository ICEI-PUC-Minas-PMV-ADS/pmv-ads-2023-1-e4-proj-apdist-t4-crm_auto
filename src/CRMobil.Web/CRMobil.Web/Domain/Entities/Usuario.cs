﻿namespace CRMobil.Web.Domain.Entities
{
    public class Usuario
    {
        public string Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Confirma_Senha { get; set; }
    }
}
