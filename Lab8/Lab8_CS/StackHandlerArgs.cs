using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_CS
{
    class StackHandlerArgs
    {
        private string _message;
        private object _sender;
        public StackHandlerArgs(string message, object sender)
        {
            _message = message;
            _sender = sender;
        }
        public string Message => _message;
        public object Object => _sender;
    }
}
