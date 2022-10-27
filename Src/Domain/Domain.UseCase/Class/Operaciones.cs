using Domain.Models.Interfaces;

namespace Domain.UseCase.Class
{
    public class Operaciones: IOperaciones
    {
        public int sumar(int numberOne, int numberTwo) 
        { 
            return numberOne + numberTwo;
        }

        public int restar(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        public int multiplicar(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        public int dividir(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }
    }
}
