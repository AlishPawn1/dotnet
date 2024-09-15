using System;
namespace dotnet.src.SessionThree.AppClass;
public class StudentIndexer{
    // public string[] nameList;
    private string[] nameList;

    public StudentIndexer(int maxSize){
        nameList = new string[maxSize];
    }

    public int getLength(){
        return nameList.Length;
    }

    // DEfining an indexer - <modifier> < return type > this [argument list]
    public string this[int index]{
        get{ return nameList[index];}
        set{ nameList[index] = value ;}
    }
}
