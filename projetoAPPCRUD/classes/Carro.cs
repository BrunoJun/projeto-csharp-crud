using System;

namespace projetoAPPCRUD
{
    public class Carro : EntidadeBase
    {   

        private Marca Marca{get; set;}

        private string Modelo{get; set;}

        private int Ano{get; set;}

        public Carro(int id, Marca marca, string modelo, int ano)
        {
            
            this.id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
        }

        public override string ToString()
        {
            
            return $"Marca: {Marca}\nModelo: {Modelo}\nAno: {Ano}";
        }

        public int retornaId(){

            return id;
        }

        public string retornaModelo(){

            return Modelo;
        }

        public int retornaAno(){

            return Ano;
        }
    }
}