namespace aula13_OTO{
    public class Pessoa{
        public int PessoaId {get; set;}
        public string Nome {get; set;} = string.Empty;
        public Endereco Endereco {get; set;} = null; // Relacionamento 1:1
    }
}