using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name
    {
        //Só conseguiremos gerar um nome com nome e sobrenome
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //Propriedades
        public String FirstName { get; private set; }
        public String LastName { get; private set; }

        //Peculiaridades/Validações
        //Um nome e um sobrenome não pode ter menos de 3 letras e no máximo 70 (nome de rei)
        //É obrigatório
        //
    }
}
