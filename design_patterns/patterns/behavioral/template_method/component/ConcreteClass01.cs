using design_patterns.patterns.behavioral.template_method.template_method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.patterns.behavioral.template_method.component
{
    public class ConcreteClass01: AbstractClass
    {
        protected override void RequireOperation01()
        {
            Console.Write("Operação sobreescrita");
        }
        
    }
}
