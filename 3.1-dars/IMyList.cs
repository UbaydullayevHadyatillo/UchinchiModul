namespace _3._1_dars;

public interface IMyList
{
    public bool Add(int num);
    public bool RemovAll(int num);
    public bool Remove(int num);
    public bool Contains(int num);
    public int IndexOf(int num);
    public bool RemovAt(int index);
    public int GetById(int index);
}