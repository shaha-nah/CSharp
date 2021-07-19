using System;

namespace Generics
{
    //types of contraints: 
    // where T : IComparable - apply constraint to interface
    // where T : Product - apply constraing to class + subclasses
    // where T : struct - value type
    // where T : class - reference type
    // where T : new() - object with default constructor
    
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}