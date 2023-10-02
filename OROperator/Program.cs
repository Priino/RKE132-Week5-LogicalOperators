////Math >= 90 OR Chemistry >= 90

//int math, biology, chemistry;

//Console.WriteLine("Enter your Math result");
//math = Int32.Parse(Console.ReadLine());

////Console.WriteLine("Enter your Biology result");
////biology = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Enter your Chemystry result");
//chemistry = Int32.Parse(Console.ReadLine());

//if (math >= 90 || chemistry >= 90)
//    {
//        Console.WriteLine("Congratulations! You got accsepted");
//    }
//    else
//    {
//        Console.WriteLine("Your application cannot approved");
//    }


//math >= 90 || chemistry >= 90
//math && chemistry || math && biology || chemisrty && biology

int math, biology, chemistry;

Console.WriteLine("Enter your Math result");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemystry result");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accsepted");
}
else
{
    Console.WriteLine("Your application cannot approved");
}