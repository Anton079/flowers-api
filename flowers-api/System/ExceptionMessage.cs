namespace flowers_api.System
{
    public class ExceptionMessage
    {
        public static readonly string FlowerExistException = "Atributul flower deja exista!";

        // General Flower Exception
        public static readonly string NullFlowerException = "Obiectul flower este null!";
        public static readonly string IdExpceiton = "Atributul id nu poate fi mai mic sau egal cu 0!";

        // Attribute Exceptions
        public static readonly string NullIdException = "Atributul id este null!";
        public static readonly string NullTypeException = "Atributul type este null, trebuie să îl completezi!";
        public static readonly string NullPriceException = "Atributul price este null, trebuie să îl completezi!";
        public static readonly string NullRatingException = "Atributul rating este null, trebuie să îl completezi!";

        // Attribute Already Exists Exceptions
        public static readonly string IdExistException = "Atributul id există deja!";
        public static readonly string TypeExistException = "Atributul type există deja!";
        public static readonly string PriceExistException = "Atributul price există deja!";
        public static readonly string RatingExistException = "Atributul rating există deja!";
    }
}
