namespace _3._1_dars;

public class MyList : IMyList
{
    private int[] _nums;
    private int arrIndex = 0;
    public int Capacity
    {
        get { return _nums.Length; }
    }

    public MyList(int capacity = 4)
    {
        _nums = new int[capacity];
    }
    private void DoubleCapacity()
    {
        int[] newArr = new int[Capacity * 2];
        for(var i = 0; i < Capacity;i++)
        {
            newArr[i] = _nums[i];
        }
        _nums = newArr;
    }

    public bool Add(int num)
    {
        if (arrIndex >= Capacity)
        {
            DoubleCapacity();
        }
        _nums[arrIndex] = num;
        arrIndex++;
        return true;
    }

    public bool RemovAll(int num)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int num)
    {
        for(var i= 0; i<Capacity;i++)
        {
            if (_nums[i] == num)
            {
                for(var j =0; j < Capacity -1;j++)
                {
                    _nums[j] = _nums[j+1];
                }
                --arrIndex;
                return true;    
            }
        }
        return false;
    }

    public bool Contains(int num)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(int num)
    {
        for(int i=0; i<Capacity; i++)
        {
            if( _nums[i] == num)
            {
                return i;
            }
        }
        return -1;
    }

    public bool RemovAt(int index)
    {
        throw new NotImplementedException();
    }

    public int GetById(int index)
    {
        return _nums[index];
    }
}
