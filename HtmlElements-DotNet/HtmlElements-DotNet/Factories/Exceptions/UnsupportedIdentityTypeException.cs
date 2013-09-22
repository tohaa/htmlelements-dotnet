﻿using System;

namespace Yandex.HtmlElements.Factories.Exceptions
{
    public class UnsupportedIdentityTypeException : Exception
    {
        public UnsupportedIdentityTypeException()
            : base()
        {
        }

        public UnsupportedIdentityTypeException(string message)
            : base(message)
        {
        }

        public UnsupportedIdentityTypeException(string message, Exception isserException)
            : base(message, isserException)
        {
        }
    }
}
