using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.UizaHandleException
{
    /// <summary>
    /// 
    /// </summary>
    public class UizaException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public UizaExceptionResponse UizaInnerException { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public UizaException()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public UizaException(string message)
            : base(message)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public UizaException(string message, Exception ex)
            : base(message, ex)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="error"></param>
        public UizaException(UizaExceptionResponse error)
            : base(error.Message)
        {
            this.UizaInnerException = error;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="error"></param>
        public UizaException(string message, UizaExceptionResponse error)
            : base(message)
        {
            this.UizaInnerException = error;
        }
    }
}
