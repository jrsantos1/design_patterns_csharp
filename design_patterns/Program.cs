﻿using design_patterns.patterns.behavioral.template_method;
using design_patterns.patterns.behavioral.visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ClientVisitor().run();

            new TempleteMethodClient().run();

        }
    }
}
