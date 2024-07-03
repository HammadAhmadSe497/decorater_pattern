public class Borrower : Decorator
{
    private List<string> listOfborrowers = new List<string>();
    public Borrower(LibraryItem item) : base(item)
    {

    }
    public void BorrowItem(string borrowerName)
    {
        listOfborrowers.Add(borrowerName);
        libraryItem.NoOfCopies--;
    }
    public void ReturnItem(string borrowerName)
    {
        listOfborrowers.Remove(borrowerName);
        libraryItem.NoOfCopies++;
    }
    public override void Display()
    {
        libraryItem.Display();
        foreach (string borrower in listOfborrowers)
        {
            Console.WriteLine("Borrower: {0}", borrower);
        }
    }
}