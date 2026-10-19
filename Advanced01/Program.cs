
namespace Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //a generic class uses a type parameter so the same
            //class can work with different types.
            #endregion
            #region Q3
            //Multiple type parameters let a generic class work with more than one type
            #endregion
            #region Q4
            //A generic method is a method with its own type parameter,
            //so it can work with different types.
            #endregion
            #region Q6
            //generic interface defines a contract that works with a type supplied by the class or method implementing it.
            #endregion
            #region Q7
            //It restricts the generic type to value types that are non-nullable.
            //example class animal<T> where T:struct
            #endregion
            #region Q8
            //It restricts the generic type to reference types.
            //example class animal<T> where T:class
            #endregion
        }
    }
}
