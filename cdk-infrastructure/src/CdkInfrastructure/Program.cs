using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CdkInfrastructure
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new CdkInfrastructureStack(app, "CdkInfrastructureStack");
            app.Synth();
        }
    }
}
