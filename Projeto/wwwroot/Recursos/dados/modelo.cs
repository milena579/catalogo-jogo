using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.wwwroot.Recursos.dados
{
    public class modelo
    {
        [DataContract]
        public abstract class BaseModel
        {
            [DataMember]
            public int Id { get; protected set; }
        }

        public class Produto : BaseModel
        {
            public Agente ()
            {

            }

            [Required]
            public int Codigo { get; private set; }
            [Required]
            public string Posicao { get; private set; }
            [Required]
            public string Nome { get; private set; }
            [Required]
            public string Nacionalidade{ get; private set; }
            [Required]
            public string Habilidades { get; private set; }
            

            public Agentes(string codigo, string nome, string posicao, string nacionalidade, string habilidades)
            {
                this.Codigo = codigo;
                this.Posicao = posicao;
                this.Nome = nome;
                this.Nacionalidade = nacionalidade;
                this.Habilidades = habilidades;
            }
        }

        public class Usuario : BaseModel
        {
            public Usuario ()
            {
            }

            [Required]
            public int idUsuario { get; set; } = "";
            [Required]
            public string Nome { get; set; } = "";
            [Required]
            public string Email { get; set; } = "";
            [Required]
            public string Senha { get; set; } = "";
            [Required]
            public DateTime Datanasc { get; set; } = "";

            
        }

        public class Arsenal : BaseModel
        {
            [Required]
            public string Tipo { get; private set; }
            [Required]
            public string Nome { get; private set; }
            [Required]
            public string Estatisticas { get; private set; }
            [Required]
            public decimal Preco { get; private set; }

            public Arsenal()
            {

            }

            public Arsenal(string tipo, string nome, string estatisticas, string preco)
            {
                this.Tipo = tipo;
                this.Nome = nome;
                this.Estatisticas = estatisticas;
                this.Preco = preco;

            }
        }

        public class Forum: BaseModel
        {
            [Required]
            public int Codigo { get; private set; }
            [Required]
            public DateTime Data { get; private set; }
            [Required]
            public string Assunto { get; private set; }
            [Required]
            public string Resposta{ get; private set; }
            [Required]
            public Usuario Usuario { get; private set; }

            public Forum()
            {

            }

            public Forum(int codigo, DateTime data, string assunto, string resposta, Usuario usuario)
            {
                this.Codigo = codigo;
                this.Data = data;
                this.Assunto = assunto;
                this.Resposta = resposta;
                this.Usuario = usuario;
            }
        }

        public class Forum : BaseModel
        {
            public Forum()
            {
                Usuario = new Usuario();
            }

            public Forum(Usuario usuario)
            {
                Usuario = usuario;
            }

            //public List<> Itens { get; private set; } = new List<ItemPedido>();
            //[Required]
            //public virtual Cadastro Cadastro { get; private set; }


        }

        public class Respostas : BaseModel
        {
            [Required]
            public int Codigo { get; private set; }
            [Required]
            public string Resposta { get; private set; }
            [Required]
            public DateTime Data { get; private set; }
            [Required]
            public Forum forum{ get; private set; }
            
            public Respostas()
            {

            }

            public Respostas (int codigo, string resposta, DateTime data, Forum forum)
            {
                this.Codigo = codigo;
                this.Data = data;
                this.Resposta = resposta;
                this.Forum = forum;
            }
        }

        public class Respostas: BaseModel
        {
            public Respostas()
            {
                Forum = new Forum();
            }

            public Respostas (Furum forum)
            {
                Forum = forum;
            }

        }
    }



}
}
}
