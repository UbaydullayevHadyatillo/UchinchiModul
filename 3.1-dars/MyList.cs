using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_dars;

public class MyList : IMyList
{

    private int _capacity;

    public int Capacity
    {
        get { return _capacity; }
        set { _capacity = value; }
    }

    public MyList(int capacity = 4)
    {
        
    }
    bool IMyList.Add(int num)
    {
        throw new NotImplementedException();
    }

    bool IMyList.Contains(int num)
    {
        throw new NotImplementedException();
    }

    int IMyList.GetById(int index)
    {
        throw new NotImplementedException();
    }

    bool IMyList.IndexOf(int num)
    {
        throw new NotImplementedException();
    }

    bool IMyList.RemovAll(int num)
    {
        throw new NotImplementedException();
    }

    bool IMyList.RemovAt(int index)
    {
        throw new NotImplementedException();
    }

    bool IMyList.Remove(int num)
    {
        throw new NotImplementedException();
    }
}
