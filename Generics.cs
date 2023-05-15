using System;
using System.Collections;
class FoodDetails<T>
{
    ArrayList obj = new ArrayList();

    public void food()
    {
        Console.WriteLine("Main item in program");
        obj.Add("Indian food");    
        obj.Add("Weseten Food");
        obj.Add("ItalianFood");
        obj.Add(500);

        string name = (string)obj[0];     
        string name1 = (string)obj[1];
        string name2 = (string)obj[2];
        int price = (int)obj[3];

        Console.WriteLine(name +"\n "+name1+"\n "+ name1 +"\n "+ price);

        //Add new value

        obj.Add("Chinese Food");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("after adding item========================");
       foreach(var i in obj)
        {
                Console.WriteLine(i);
        }
        // update New Value

        obj[3] = 1000;
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("after update item===========================");
        foreach (var i in obj)
        {
             Console.WriteLine(i);
        }

        //Insert new item for an specific value

        obj.Insert(2, "Sweet");

        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("after insert item=======================");
        foreach (var i in obj)
        {
            Console.WriteLine(i);
        }


        //Remove Function

        obj.Remove("Indian food");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("after Remove item======================");
        foreach (var i in obj)
        {
            Console.WriteLine(i);
        }

        //Search function
        Console.WriteLine("Search price in program===================");
        bool flag;
        flag = obj.Contains(Console.ReadLine());
        if(flag==true)
        {
            Console.WriteLine("Value is present");

        }
        else
        {
            Console.WriteLine("Value in not present");
        }





    }
    
}
class First
{
    public static void Main(String[] args)
    {
        FoodDetails<string> obj = new FoodDetails<string>();
        obj.food();

    }

}
