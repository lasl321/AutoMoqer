using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwkwardTools.Testing
{
    public class ClassToTest
    {
        private IHelper _helper;

        public ClassToTest(IHelper helper)
        {
            _helper = helper;
        }

        public void DoSomething()
        {
            _helper.DoSomething();
        }
    }
}
