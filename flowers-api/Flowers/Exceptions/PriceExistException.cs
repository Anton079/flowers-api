using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class PriceExistException:Exception
    {
        public PriceExistException():base(ExceptionMessage.PriceExistException){}
    }
}
