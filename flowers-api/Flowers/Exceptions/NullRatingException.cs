using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class NullRatingException:Exception
    {
        public NullRatingException() :base(ExceptionMessage.NullRatingException) { }
    }
}
