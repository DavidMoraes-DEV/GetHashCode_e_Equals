using System;
using System.Collections.Generic;
using System.Text;

namespace GetHashCode_e_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj) 
        {
            if(!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client; //Down Casting
            return Email.Equals(other.Email); //Nesse caso o cliente será igual ao outro quando o email for igual.
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
