using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwkwardTools.Testing
{
    [Serializable]
    public class AutoMoqerException : Exception
    {
        public AutoMoqerException() { }
        public AutoMoqerException(string message) : base(message) { }
        public AutoMoqerException(string message, Exception inner) : base(message, inner) { }
        protected AutoMoqerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
