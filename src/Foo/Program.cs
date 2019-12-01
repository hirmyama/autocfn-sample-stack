using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Foo
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new FooStack(app, "FooStack");
            app.Synth();
        }
    }
}
