namespace ApiCleanArch.Models
{
    public class Pessoa
    {
            public string Nome { get; set; } = string.Empty;
            public DateTime DataNascimento { get; set; }
            public string Email { get; set; } = string.Empty;
            public string Telefone { get; set; } = string.Empty;
            public string Endereco { get; set; } = string.Empty;
            public string Cidade { get; set; } = string.Empty;
            public string Estado { get; set; } = string.Empty;
            public string Pais { get; set; } = string.Empty;
            public string CEP { get; set; } = string.Empty;
            public string CPF { get; set; } = string.Empty;
            public string RG { get; set; } = string.Empty;
            public string CNH { get; set; } = string.Empty;
            public string TituloEleitor { get; set; } = string.Empty;
            public string Passaporte { get; set; } = string.Empty;
            public string CarteiraTrabalho { get; set; } = string.Empty;
    }
}