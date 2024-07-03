public class Decorator : LibraryItem
{
    protected LibraryItem libraryItem;
    public Decorator(LibraryItem item)
    {
        libraryItem = item;
    }
    public override void Display()
    {
        libraryItem.Display();
    }
}