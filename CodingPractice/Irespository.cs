using System;
using System.Collections.Generic;
using System.Text;

interface IRepository
{
    void Get();
}

class Repository : IRepository
{ 
    public void Get()
    {
        Console.WriteLine("데이터를 가져옵니다.");
    }
}
