using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Reflection;

namespace AwkwardTools.Testing
{
    public class ExploratoryTests : AutoMoqer<ClassToTest>
    {
        protected override void RunBeforeEachTest()
        {
            Console.WriteLine(MethodInfo.GetCurrentMethod().Name);
        }

        protected override void RunAfterEachTest()
        {
            Console.WriteLine(MethodInfo.GetCurrentMethod().Name);
        }

        [Test]
        public void ShouldDoSomething()
        {
            Sut.DoSomething();
        }

        [Test]
        [ExpectedException(typeof(AutoMoqerException))]
        public void ShouldFailDueToMultipleConstructors()
        {
            var instance = new ClassWithMultipleConstructorsWrapper();
            instance.SetUp();
        }

        [Test]
        public void ShouldThrowException()
        {
            var a = new[] { "a", "b", "c" };

            var r = a.SingleOrDefault();

            Assert.That(r, Is.EqualTo("a"));
        }
    }

    public class ClassWithMultipleConstructorsWrapper : AutoMoqer<ClassWithMultipleConstructors>
    {
    }
}
