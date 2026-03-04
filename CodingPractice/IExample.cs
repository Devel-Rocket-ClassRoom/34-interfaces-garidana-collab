using System;
using System.Collections.Generic;
using System.Text;

interface IExample
{
    void DoWork();
}

class Example : IExample
{
    void IExample.DoWork() // public 키워드 없이 명시적 구현
    {
        Console.WriteLine("작업 수행");
    }
}