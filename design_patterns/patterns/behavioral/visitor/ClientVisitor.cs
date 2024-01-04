using design_patterns.patterns.behavioral.visitor.component;
using design_patterns.patterns.behavioral.visitor.visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.patterns.behavioral.visitor
{
    public class ClientVisitor: PatternClient
    {
        public void run()
        {
            var concreteA = new ConcreteComponentA();
            concreteA.Accept(new ConcreteVisitorA());

            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
