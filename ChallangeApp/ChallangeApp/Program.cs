string name = "Ewa";
string sex = "kobieta";
int age = 33;
if(sex=="kobieta" && age<30)
{ Console.WriteLine("Kobieta poniżej 30 lat");
}
else { Console.WriteLine("Mężczyzna powyżej 30 lat"); 
}
if (age == 33) 
{ if (name=="Ewa")
    { Console.WriteLine("Ewa lat 33"); 
    }
}
else { Console.WriteLine ("Kobieta lat 30"); 
}
if(!(sex=="kobieta"))
    { if (age<18)
    { Console.WriteLine("Niepełnoletni mężczyzna"); 
    }
}
else { Console.WriteLine("Pełnoletni mężczyzna");
}
