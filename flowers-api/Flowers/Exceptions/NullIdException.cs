using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class NullIdException:Exception
    {
        public NullIdException() :base(ExceptionMessage.NullIdException) {}
    }
}
