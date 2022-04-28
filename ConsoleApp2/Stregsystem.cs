
// See https://aka.ms/new-console-template for more information


class Stregsystem
{

    void Foo()
    {
        Ui.ShowError("Der skete en fejl");
    }
    public Stregsystem(IStregsystemUI ui)
    {
        Products.Add(new Product { Id = 11, Navn = "Sodavand", Price = 14 });
        Products.Add(new Product { Id = 14, Navn = "Øl", Price = 7 });
        Ui = ui;
    }
    List<User> Users = new List<User>();
    public List<Product> Products = new List<Product>();

    public IStregsystemUI Ui { get; }
}
