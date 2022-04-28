
// See https://aka.ms/new-console-template for more information



interface IIdSource
{
    int GetNextId();
}

struct V
{
    public int Id;
    public string Name;
}

class StaticIdCount : IIdSource
{
    private static int _IDCounter = 0;
    public int GetNextId()
    {
        return ++_IDCounter;
        V v = new V();
        V v2 = new V();
        v.i = 10;
        v2.i = 20;

        

        V vref = v;
        vref.i = 30;

        Console.WriteLine(v.i);




        V.k = 30;

    }
}


class V
{
    public static int k;
    public int i;
}

class Transaction
{
    private static int _IDCounter = 0;
    private static int NExtID => ++_IDCounter;
    int GetNextId()
    {
        return ++_IDCounter;
    }
    public Transaction(IIdSource idSource)
    {
        Id  = idSource.GetNextId();
    }
    public int Id { get;} = NExtID;
}


interface IStregsystemUI
{
    void Start();
    void ShowError(string v);
}

class ConsoleUI : IStregsystemUI
{


    public ConsoleUI(Stregsystem s)
    {
        S = s;
    }

    public Stregsystem S { get; }

    public void ShowError(string v)
    {
        
    }

    public void Start()
    {
        foreach(Product? p in S.Products)
        {
            Console.WriteLine(p);
        }
    }
}

class SEasonalProduct : Product
{

}


class SS
{
    List<Product> products = new List<Product> { new Product(), new SEasonalProduct() };
}

class Product
{
    public override string ToString()
    {
        return $"{Id} | {Navn} | {Price}";
    }
    public int Id { get; set; }
    public string Navn { get; set; }
    public decimal Price { get; set; }
}

class User
{

    public User Self()
    {
        return this;
    }

    public string Username { get; set; }
    private decimal _balance;
    public decimal Balance
    {
        get
        {
            return _balance;
        }
        set
        {
            _balance = value;
            BalanceChanged(this);
        }
    }
    public event BalanceChangedNotification BalanceChanged;
}

class P
{
    void m()
    {


    }
}

delegate void BalanceChangedNotification(User u);




class Book
{
    public string Title { get; set; }
    public string Description { get; set; }
}
