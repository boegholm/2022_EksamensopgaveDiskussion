// See https://aka.ms/new-console-template for more information



class Person : Object
{
    public Person(int alder)
    {
        Alder = alder;
    }
    public string Name { get; set; }
    public string CPR { get; set; }
    public int Alder { get; set; }

    public override bool Equals(object? obj)
    {
        if(obj == null) return false;
        if(obj.GetType() != typeof(Person)) return false;
        Person np = (Person)obj;
        return np.CPR.Equals(CPR);
    }

    Dictionary<string, Person> katalog = new Dictionary<string, Person>();

    public override int GetHashCode()
    {

        return (CPR.GetHashCode());
    }
}
