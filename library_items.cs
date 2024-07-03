
 public abstract class LibraryItem{
    protected int noOfCopies;
    public int NoOfCopies{
        get{
            return noOfCopies;
        }
        set{
            noOfCopies = value;
        }
    }
    public abstract void Display();
}