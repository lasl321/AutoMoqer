using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AwkwardTools.Testing
{
    internal class ConstructorExtractor
    {
        public ConstructorInfo Extract<T>()
        {
            var constructors = typeof(T).GetConstructors();

            try
            {
                return constructors.Single();
            }
            catch (InvalidOperationException e)
            {
                throw new AutoMoqerException("Single public constructor required", e);
            }
        }
    }
}
