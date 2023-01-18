string name = "Justyna";
string sex = "kobieta";
int age = 39;
if(sex=="kobieta" && age<30)
{ Console.WriteLine("Kobieta poniżej 30 lat"); }
if (age == 39) 
{ if (name=="Justyna")
    { Console.WriteLine("Justyna lat 39"); }
}
if(!(sex=="kobieta"))
    { if (age<18)
    { Console.WriteLine("Niepełnoletni mężczyzna"); }
}
