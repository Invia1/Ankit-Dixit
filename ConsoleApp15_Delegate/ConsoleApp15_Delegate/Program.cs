
delegate string ChildDelegate();

delegate void Mystudy(string n);

delegate int AgeDelegate();
class Boys
{
        public string Name()
    {
        return "Ankit";
    }

    public string Address()
    {
        return "Noida";
    }

    public int Age()
    {
        return 25;
        
    }

    public void study(string pn)
    {
        Console.WriteLine(pn);
    }



}

class Program
{
    public static void Main()
    {
        Boys obj = new Boys();

        ChildDelegate play = new ChildDelegate(obj.Name);
        

        var temp = play();
        Console.WriteLine("Name :" + temp);

        play += obj.Address;

        var temp1 = play();
        Console.WriteLine("Address :" + temp1);

        Mystudy objp=new Mystudy(obj.study);
        objp("Education :" + "Beacholer");

        AgeDelegate obj1 = new AgeDelegate(obj.Age);
        var temp2 = obj1();
        Console.WriteLine("Age is :" + temp2);




    }
}