int Products = 72;              //Skriv antall varer (maks 99, går en over vil man få feilmld)
string Prod1 = "Melk";          //Vare 1, Melk
string Prod2 = "Egg";           //Vare 2, Egg
string Prod3 = "Sennep";        //Vare 3, Sennep

switch (Products)
{ 
    case <10: //under 10stk, gir 10% i rabatt
    {
        Console.WriteLine(Prod1 + ", " + Products + "stk = 10% rabatt");
        break;
    }
    case <25: //under 25stk, gir 25% i rabatt
        {
            Console.WriteLine(Prod2 + ", " + Products + "stk = 25% rabatt");
            break;
        }
    case <99: //under 99stk, gir 40% i rabatt
        {
            Console.WriteLine(Prod3 + ", " + Products + "stk = 40% rabatt");
            break;
        }    
    default: //mer enn 99stk, gir feilmld: "No products, invalid number"
        {
            Console.WriteLine("No products, invalid number");
            break;
        }
}