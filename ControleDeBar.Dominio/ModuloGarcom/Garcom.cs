using ControleDeBar.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleDeBar.Dominio.ModuloGarcom
{
    public class Garcom : EntidadeBase<Garcom>
    {
        public string Cpf { get; set; }

        public string Nome { get; set; }

        public Garcom() { }

        public Garcom(string cpf, string nome) : this()
        {
            Id = Guid.NewGuid();
            Cpf = cpf;
            Nome = nome;
        }

        public override void AtualizarRegistro(Garcom registroEditado)
        {
            Nome = registroEditado.Nome;
            Cpf = registroEditado.Cpf;
        }

    }   
}
