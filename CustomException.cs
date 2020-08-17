using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace IntroToCSharp
{
    [Serializable]
    public class CustomException : Exception
    {
        #region Constructors
        public CustomException()
           :base()
        {

        }
        public CustomException(string message)
          : base(message)
        {

        }
        public CustomException(string message, Exception innerException)
          : base(message:message,innerException:innerException)
        {

        }

        public CustomException(SerializationInfo info, StreamingContext context)
         : base(info:info,context:context)
        {

        }
        #endregion

        #region Property
        public override string HelpLink
        {
            get { return base.HelpLink; }
            set { base.HelpLink = value; }
            
        }
        #endregion
    }
}
