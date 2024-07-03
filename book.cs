public class Book : LibraryItem
{
private string bookTitle;
private string bookAuthor;
public Book(string title, string author, int noOfCopies)
{
bookTitle = title;
bookAuthor = author;
NoOfCopies = noOfCopies;

}
public override void Display()
{
Console.WriteLine("---------------Book Details---------------");
Console.WriteLine("Book Title: {0}", bookTitle);
Console.WriteLine("Book Author: {0}", bookAuthor);
Console.WriteLine("Number of Copies: {0}", NoOfCopies);
}


}