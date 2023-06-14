using System;
using System.Collections;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        Book a = new Book(1, 2, 3, 4, 5, 6, "sdds", 34.23d,22.23f,2,'s',"AbD");
        foreach(var i in a)
            Console.WriteLine(i);
        
        Console.ReadKey();
        }

    }
class Book : IEnumerable<object>
{
    object[] _arr;
    public Book(params object[]arr) 
    {
        _arr = new object[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            _arr[i] = arr[i];
    }
    //
    public IEnumerator<object> GetEnumerator() => new BookEnum(_arr);
    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)GetEnumerator();
    //
    class BookEnum : IEnumerator<object>
    {
        object[] _mydata;
        int index = 0;
        public object Current => _mydata[index];
        public BookEnum(object[]mydata) 
        {
            _mydata = new object[mydata.Length];
            for (int i = 0; i < mydata.Length; i++)
                _mydata[i] = mydata[i];
        }
        public bool MoveNext()
        {
            index++;
            return (index<_mydata.Length);
        }

        public void Reset()
        {
            index = 0;
        }

        public void Dispose()
        {
           
        }
    }
}

