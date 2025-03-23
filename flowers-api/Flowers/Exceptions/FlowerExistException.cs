using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class FlowerExistException: Exception
    {
        public FlowerExistException() :base(ExceptionMessage.FlowerExistException) { }
    }
}
