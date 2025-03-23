using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class TypeExistException:Exception
    {
        public TypeExistException() :base(ExceptionMessage.TypeExistException) { }
    }
}
