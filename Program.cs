using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main( string[] args)
    {
        Book book = new Book("The Da Vinci Code", "Dan Brown", 5);
        book.Display();
        Borrower borrower = new Borrower(book);
        borrower.BorrowItem("Hammad");
        borrower.BorrowItem("Ahsan");
        borrower.BorrowItem("Ali");
        borrower.Display();

    }
}