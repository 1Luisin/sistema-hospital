using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sistema_hospital_csharp
{
    public class Paciente
    {
        public int Idade;
        public char[] TpSexo = { 'M', 'F', 'P' };
        public string? Nome;
        public string? Cidade;
        public string[] EstadoCivil = { "Casado(a)", "Solteiro(a)", "Divorciado(a)", "Viúvo(a)" };
        public string[] Raça = {"Preto","Branco","Pardo","Indígena","Amarelo"};  

    }
}
