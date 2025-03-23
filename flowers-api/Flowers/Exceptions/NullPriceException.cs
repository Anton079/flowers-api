using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class NullPriceException :Exception
    {
        public NullPriceException() :base(ExceptionMessage.PriceExistException) { }
    }
}
