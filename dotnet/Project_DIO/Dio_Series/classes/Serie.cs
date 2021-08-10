namespace Dio_Series
{
    public class Serie : Entidade
    {
        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero;
            retorno += "Titulo: " + this.Titulo;
            retorno += "Descrição: " + this.Descricao;
            retorno += "Ano: " + this.Ano;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int RetornaId()
        {
            return this.Id;
        }
    }
        

}