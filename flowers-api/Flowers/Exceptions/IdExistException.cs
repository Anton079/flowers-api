using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class IdExistException:Exception
    {
        public IdExistException() :base(ExceptionMessage.IdExistException) {}
    }
}
