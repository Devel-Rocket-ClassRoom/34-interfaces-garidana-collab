using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

interface IUndoable
{
    void Undo();
}

interface IRedoable : IUndoable
{
    void Redo();
}

class TextEditor : IRedoable
{
    public void Undo()
    {
        Console.WriteLine("실행 취소");
    }
    public void Redo()
    {
        Console.WriteLine("다시 실행");
    }
}