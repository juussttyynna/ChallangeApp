int number = 1899568222;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray(); 

List<char> numbers = new List<char>();
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

foreach (var digit in numbers)
{
    var count = 0;
    
    foreach (var x in letters) 
    {
        if (digit == x) count++;
    }
    Console.WriteLine(digit + "=>" + count++);
    
}