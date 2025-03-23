using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class NullTypeException:Exception
    {
        public NullTypeException() :base(ExceptionMessage.NullTypeException) { }
    }
}
