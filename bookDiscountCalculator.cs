using System;

class Book
{
    string title;
    string author;
    double price;
    bool isBestSeller;
    double discountedPrice;

    public Book(string bookTitle, string bookAuthor, double bookPrice, bool bookBestSeller)
    {
        title = bookTitle;
        author = bookAuthor;
        price = bookPrice;
        isBestSeller = bookBestSeller;
    }

    public void calculateDiscountedPrice()
    {
        double bestSellerDiscount = 0;
        double priceDiscount = 0;

        if (isBestSeller)
        {
            bestSellerDiscount = price * 0.1;
        }

        if (price > 500)
        {
            priceDiscount = price * 0.05;
        }

        discountedPrice = price - bestSellerDiscount - priceDiscount;
    }

    public void printDiscountedPrice()
    {
        Console.WriteLine($"Discounted price of \"{title}\": {discountedPrice}");
    }

    public static void Main(string[] args)
    {
        Book book1 = new Book("Psychology of Money", "Morgan", 900, false);
        book1.calculateDiscountedPrice();
        book1.printDiscountedPrice();

        Book book2 = new Book("Do Nothing", "Rushabh", 690, true);
        book2.calculateDiscountedPrice();
        book2.printDiscountedPrice();
    }
}
