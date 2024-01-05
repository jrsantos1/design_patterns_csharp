using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.patterns.behavioral.template_method.template_method
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            this.BaseOperation01();
            this.BaseOperation02();
            this.RequireOperation01();
        }

        protected void BaseOperation01()
        {
            Console.WriteLine("Base01 Não sobreescrito");
        }
        protected void BaseOperation02()
        {
            Console.WriteLine("Base01 Não sobreescrito");
        }
        protected abstract void RequireOperation01();



    }
}
