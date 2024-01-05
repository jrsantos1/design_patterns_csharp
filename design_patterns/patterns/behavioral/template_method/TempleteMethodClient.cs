using design_patterns.patterns.behavioral.template_method.component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.patterns.behavioral.template_method
{
    public class TempleteMethodClient : PatternClient
    {
        public void run()
        {
            var concreteClass = new ConcreteClass01();
            concreteClass.TemplateMethod();

            Console.ReadLine();

        }
    }
}
