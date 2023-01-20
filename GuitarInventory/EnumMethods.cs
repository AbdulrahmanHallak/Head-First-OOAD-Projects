using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GuitarInventory
{
    internal class EnumMethods
    {
       public static string GetString(Type s)
        {
            switch(s)
            {
                case Type.ACOUSTIC:

                    return "Acoustic";
                    break;

                case Type.ELECTRIC:
                    return "Electric";
                    break;
            }
            return null;
        }
    }
}
