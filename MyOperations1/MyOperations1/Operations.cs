using MyOperations1;
using System;

namespace MyOperations1
{
    public class Operations
    {
        public int DivideNumbers(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(1001, "Cannot divide by zero");
            }
        }

        public int GetArrayElement(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(1002, "Index is out of array bounds");
            }
        }
    }
}