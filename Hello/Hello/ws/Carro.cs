using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.ws
{
    internal class Carro
    {
        public string marca;
        public string modelo;
        public string matricula;
        public int ano;

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getMarca()
        {
            return marca;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getModelo()
        {
            return modelo;
        }
        public void setMatricula(string matricula)
        {
            this.matricula = matricula;
        }

        public string getMatricula()
        {
            return matricula;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }

        public int getAno()
        {
            return ano;
        }

        public Carro(string marca, string modelo, string matricula, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.matricula = matricula;
            this.ano = ano;
        }

        public Carro()
        {
            this.marca = "";
            this.modelo = "";
            this.matricula = "";
            this.ano = 0;

        }
        public void mostraDados()
        {
            Console.WriteLine(marca);
            Console.WriteLine(modelo);
            Console.WriteLine(matricula);
            Console.WriteLine(ano);

        }
    }
}