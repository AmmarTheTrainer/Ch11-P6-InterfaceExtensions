using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P6_InterfaceExtensions
{
    public interface IMath
    {

    }

    public class Math : IMath
    {
        
    }
    public class Math2 : IMath
    {

    }

    static class MathExtensions
    {
        public static void MathExtensionMethods(this IMath im)
        {

        }
    }
}
