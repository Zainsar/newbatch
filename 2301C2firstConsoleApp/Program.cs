// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, Haris!");

//DATATYPES
/*
 
int age = 18;
long daysLived = 14636213256L;
float percentage = 78.99F;
double speedOflight = 3.8374847374894767;
decimal points = 4.993M;



//char favCharacter = '\n';
//string name = "Haris Nasser";
// bool istrue= true;

//Console.WriteLine("Enter Your Name?");
//string UserName= Console.ReadLine();

//Console.WriteLine("Welcome, " + UserName);

//Operators
int a = 30, b = 10;
//Arithmetical Operators
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

// assignment operators
a += 23;// a = a + 23
Console.WriteLine(a);
a -= 23;// a = a - 23
Console.WriteLine(a);
a *= 3;// a = a * 3
Console.WriteLine(a);
a /= 3;// a = a / 3
Console.WriteLine(a);


// Comparison operaators
Console.WriteLine(a == b);//False
//Console.WriteLine(a != b);//True
//Console.WriteLine(a < b);//False
//Console.WriteLine(a > b);//True
Console.WriteLine(a <= b);//False
Console.WriteLine(a >= b);//True

// Logical Operators
//And

Console.WriteLine(a <= b && a != b);

//Or
Console.WriteLine(a <= b || a != b);

//Not
Console.WriteLine(!(a <= b) && a != b);

// Conditional Statements


Console.WriteLine("Please Enter Your Age : ");

int age = Int32.Parse(Console.ReadLine());

//if else ladder
if (age >18 )
{
    Console.WriteLine("You are Eligible to vote.");
}
else if (age == 18)
{
    //Nested if else ladder

    Console.WriteLine("Do you have NIC..? Press 'Y' for yes and 'N' for no");

    char status = char.Parse(Console.ReadLine());
    if(status =='Y' || status == 'y')
    {
        Console.WriteLine("You can Vote.");
    }
    else if (status == 'N' || status == 'n')
    {
        Console.WriteLine("Sorry, You can't Vote.");
    }
   else 
    {
        Console.WriteLine("Press Y or N only.");
    }
}
else
{
    Console.WriteLine("Sorry, You are not Eligible to vote.");
}
// Switch
Console.WriteLine("Please enter number for days from 1 to 7");
int day = Int32.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Today is Monday..");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday..");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday..");
        break;
    case 4:
        Console.WriteLine("Today is Thursday..");
        break;
    case 5:
        Console.WriteLine("Today is Friday..");
        break;
    case 6:
        Console.WriteLine("Today is Saturday..");
        break;
    case 7:
        Console.WriteLine("Today is Sunday..");
        break;
    default:
        Console.WriteLine("Invalid Number");
        break;

}

//Loops


//For
for (int i=1; i <= 100; i++)
{
    Console.WriteLine(i);
}
//reverse counting
for (int i = 100; i <=1; i--)
{
    Console.WriteLine(i);
}

//even
for (int i = 2; i <= 100; i += 2)
{
    Console.WriteLine(i);
}
//odd
for (int i = 1; i <= 100; i += 2)
{
    Console.WriteLine(i);
}
//5 table
for (int i = 5; i <= 50; i += 5)
{
    Console.WriteLine(i);
}

//While

int j = 0;
while ( j <= 10)
{
    Console.WriteLine(j);
    j++;
}

*/
//Do While

//int k = 0;
//do
//{
//   Console.WriteLine(k);
//  k++;
//
//}
//while (k > 10);


//Console.WriteLine("Please enter number for days from 1 to 7");
//int day = Int32.Parse(Console.ReadLine());

//char choice;

//do
//{
//    switch (day)
//    {
//        case 1:
//            Console.WriteLine("Today is Monday..");
//            break;
//        case 2:
//            Console.WriteLine("Today is Tuesday..");
//            break;
//        case 3:
//            Console.WriteLine("Today is Wednesday..");
//            break;
//        case 4:
//            Console.WriteLine("Today is Thursday..");
//            break;
//        case 5:
//            Console.WriteLine("Today is Friday..");
//            break;
//        case 6:
//            Console.WriteLine("Today is Saturday..");
//            break;
//        case 7:
//            Console.WriteLine("Today is Sunday..");
//            break;
//        default:
//            Console.WriteLine("Invalid Number");
//            break;

//    }
//    Console.WriteLine("Please press y to continue or any key to exit");
//    choice = Convert.ToChar(Console.ReadLine());
//}
//while (choice == 'Y' || choice == 'y');

//array

//int[] evenNumber = new int[6];

//for (int i = 0;i < evenNumber.Length; i++)
//{
//    Console.WriteLine($"Please {i+1} value for even Numbers array");
//    evenNumber[i] =Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Your Entered Array is:");

//for (int a = 0; a < evenNumber.Length; a++)
//{
//    Console.WriteLine(evenNumber[a]);
//}

// binarysearch

//int index = Array.BinarySearch(evenNumber, 22);
//    Console.WriteLine(index);

//int index1 = Array.IndexOf(evenNumber, 2);
//Console.WriteLine(index1);

//int lastindex = Array.LastIndexOf(evenNumber, 2);
//Console.WriteLine(lastindex);

//int[] evenNumber = new int[6];

//for (int i = 0; i < evenNumber.Length; i++)
//{
//    int num;
//    do
//    {
//        Console.WriteLine($"Please enter value {i + 1} for the even numbers array:");
//        string input = Console.ReadLine();
//        if (!int.TryParse(input, out num))
//        {
//            Console.WriteLine("Please enter a valid integer.");
//            continue;
//        }
//        if (num % 2 != 0)
//        {
//            Console.WriteLine("Please enter an even number.");
//            continue;
//        }
//        evenNumber[i] = num;
//        break;
//    } while (true);
//}

//Console.WriteLine("Your Entered Array is:");

//for (int a = 0; a < evenNumber.Length; a++)
//{
//    Console.WriteLine(evenNumber[a]);
//}

//Console.WriteLine("Enter Your obt Marks");
//double obtmarks = Double.Parse(Console.ReadLine());

//Console.WriteLine("Enter Your TotalMarks");
//double total_marks = Double.Parse(Console.ReadLine());

//void percentage()
//{

//    if (obtmarks > total_marks)
//    {
//        Console.WriteLine("Please Enter Valid ObtainMarks Number");
//    }
//    else
//    {
//        double percentage = obtmarks * 100 / total_marks;
//        var zain = Double.Round(percentage, 2);
//        Console.WriteLine($"Your Percentage is {zain}");
//    }
//}
//percentage();

//LIST

//List<string> Mobiles = new List<string>();
//string userinput;

//do
//{
//    Console.WriteLine("Enter your mobile name");

//    userinput = (Console.ReadLine()).ToLower();
//    if (userinput != "no")
//    {
//        Mobiles.Add(userinput);
//    }

//}
//while (userinput != "no");

//foreach (var item in Mobiles)
//{
//    Console.WriteLine(item);
//}

//Queue
//fifo 
using System.Collections;

//Queue<string> name = new Queue<string>();

//name.Enqueue("Zain");
//name.Enqueue("Ali");
//name.Enqueue("hassan");
//name.Enqueue("Waqar");
//name.Enqueue("Musa");
//name.Enqueue("Talha");

//name.Dequeue();
//name.Dequeue();
//name.Dequeue();

//foreach (var item in name)
//{
//    Console.WriteLine(item);
//}

//lifo
//stack
//Stack<string> name = new Stack<string>();

//name.Push("Zain");
//name.Push("Ali");
//name.Push("hassan");
//name.Push("Waqar");
//name.Push("Musa");
//name.Push("Talha");

//name.Pop();
//name.Pop();
//name.Pop();

//foreach (var item in name)
//{
//    Console.WriteLine(item);
//}


//non genric
//arraylist
//ArrayList address = new ArrayList();

//address.Add("North Karachi");
//address.Add("Sector 5c3");
//address.Add("street no 136");
//address.Add("L-354");

//ArrayList person = new ArrayList();

//person.Add("Zain Sarfraz");
//person.Add(21);
//person.Add(03172667345);
//person.Add("Node Js Developer");
//person.Remove(21);
//person.RemoveAt(0);
//person.RemoveRange(2,2);
//person.AddRange(address);
//person.Clear();
//person.Contains("Node Js Developer");

//Console.WriteLine(person[2]);

//foreach (var item in person)
//{
//    Console.WriteLine(item);
//}

//ArrayList Mobiles = new ArrayList();
//string userinput;

//do
//{
//    Console.WriteLine("Enter your Specification");

//    userinput = (Console.ReadLine()).ToLower();
//    if (userinput != "ok")
//    {
//        Mobiles.Add(userinput);
//    }

//}
//while (userinput != "ok");

//foreach (var item in Mobiles)
//{
//    Console.WriteLine(item);
//}

// |Dictionary (Generic) (key:value)

//Dictionary<string, string> accersiors = new Dictionary<string, string>();

//accersiors.Add("Product 1", "Charger");
//accersiors.Add("Product 2", "Data Cable");
//accersiors.Add("Product 3", "USB");
//accersiors.Add("Product 4", "Handfree");
//accersiors.Add("Product 5", "Smart Watch");
//accersiors.Add("Product 6", "BackCover");
//accersiors.Remove("Product 5");

//Console.WriteLine(accersiors.ContainsKey("Product 3"));
//Console.WriteLine(accersiors.ContainsValue("USB"));

//Console.WriteLine(accersiors["Product 4"]);

//for (int i = 1; i <= 6; i++)
//{
//    Console.WriteLine(accersiors["Product "+i]);

//}

//foreach (var item in accersiors)
//{
//    string[] test = item.ToString().Split(","); // return an array
//    string key = test[0].Trim('[');
//    string value = test[1].Trim(']');
//    Console.WriteLine("This is key : {0} and This is value : {1}",key,value);
//    //Console.WriteLine(key);
//    //Console.WriteLine(value);
//}


//HashTable (NON-Generic) (key:value) searching()

//Hashtable singer = new Hashtable();

//singer.Add("top 1" , "Rahat Fateh ali khan");
//singer.Add(2 , "atif aslam");
//singer.Add(3.0 , "Zain");
//singer.Add(false , 123);

//foreach (DictionaryEntry item in singer)
//{
//    Console.WriteLine(item.Key+":"+item.Value);
//}

//Console.WriteLine(singer.GetHashCode());
