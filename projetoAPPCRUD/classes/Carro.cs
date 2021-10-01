using System;

namespace projetoAPPCRUD
{
    public class Carro : EntidadeBase
    {   

        private Marca marca{get; set;}

        private string modelo{get; set;}

        private int ano{get; set;}

        public Carro(int id, Marca marca, string modelo, int ano)
        {
            
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        public override string ToString()
        {
            
            return $"Marca: {marca}\nModelo: {modelo}\nAno: {ano}";
        }

        public int retornaId(){

            return id;
        }

        public string retornaModelo(){

            return modelo;
        }

        public int retornaAno(){

            return ano;
        }
    }
}