using flowers_api.System;

namespace flowers_api.Flowers.Exceptions
{
    public class RatingExistException:Exception
    {
        public RatingExistException() : base(ExceptionMessage.RatingExistException) { }
    }
}
