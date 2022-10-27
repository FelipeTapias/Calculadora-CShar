using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface IOperaciones
    {
            int sumar(int numberOne, int numberTwo);
            int restar(int numberOne, int numberTwo);
            int multiplicar(int numberOne, int numberTwo);
            int dividir(int numberOne, int numberTwo);
    }
}
