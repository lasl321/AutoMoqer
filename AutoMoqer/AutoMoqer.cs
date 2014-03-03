using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AwkwardTools.Testing
{
    public abstract class AutoMoqer<T>
    {
        protected T Sut { get; set; }

        [SetUp]
        public void SetUp()
        {
            ConstructSut();
            RunBeforeEachTest();
        }

        private void ConstructSut()
        {
            var type = typeof(T);
            var constructors = type.GetConstructors();
            if (constructors.Count() != 1)
            {
                throw new AutoMoqerException("Multiple public constructors found");
            }
        }

        [TearDown]
        public void TearDown()
        {
            RunAfterEachTest();
        }

        protected virtual void RunBeforeEachTest()
        {
        }

        protected virtual void RunAfterEachTest()
        {
        }
    }
}
