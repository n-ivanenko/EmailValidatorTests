using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailValidatorTests
{
    public class BaseTest
    {
        protected TestContext TestContext { get; set; }

        protected string[] GetTestParameter(string parameterName)
        {
            string param = TestContext.Properties[parameterName] as string;
            return param.Split(';').Select(p => p.Trim()).ToArray();
        }
    }
}
