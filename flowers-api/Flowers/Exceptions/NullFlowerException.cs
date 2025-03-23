using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class NullFlowerException : Exception
    {
        public NullFlowerException() : base(ExceptionMessage.NullFlowerException) { }
    }
}
