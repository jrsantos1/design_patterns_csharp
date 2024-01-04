using design_patterns.patterns.behavioral.visitor.component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.patterns.behavioral.visitor.visitor
{
    internal class ConcreteVisitorA: IVisitor
    {
        public void VisitConcreteComponentA(ConcreteComponentA element)
        {
            Console.WriteLine("Action ComponentA VisitorA");
        }

        public void VisitConcreteComponentB(ConcreteComponentB element)
        {
            Console.WriteLine("Action ComponentB VisitorA");
        }
    }
}
