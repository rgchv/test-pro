namespace ConsoleApp2;

public class Trash
{
    private List<object> _objects = new List<object>();

    public void AddObjectToTrash(object item)
    {
        _objects.Add(item);
    }
    
}