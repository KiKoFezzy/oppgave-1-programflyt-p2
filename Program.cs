int Products = 5; 
string Prod1 = "Melk";
string Prod2 = "Egg";
string Prod3 = "Sennep";

switch (Products)
{ 
    case <10:
    {
        Console.WriteLine(Prod1 + ", " + Products + "stk = 10% rabatt");
        break;
    }
    case <25:
        {
            Console.WriteLine(Prod2 + ", " + Products + "stk = 25% rabatt");
            break;
        }
    case <99:
        {
            Console.WriteLine(Prod3 + ", " + Products + "stk = 40% rabatt");
            break;
        }    
}