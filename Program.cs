int Products = 69; 

switch (Products)
{ 
    case <10:
    {
        Console.WriteLine(Products + "stk = 10% rabatt");
        break;
    }
    case <25:
        {
            Console.WriteLine(Products + "stk = 25% rabatt");
            break;
        }
    case <99:
        {
            Console.WriteLine(Products + "stk = 40% rabatt");
            break;
        }    
}