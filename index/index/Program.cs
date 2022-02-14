using System.Text.RegularExpressions;

class MyClass
{
    

     public static void Main(string[] args)
        {

        var stringInput = "SHAPE, X, Y, LENGTH, POINTS; CIRCLE ,3,1,13,100; CIRCLE ,1,-1,15,200; SQUARE, -1 ,0 ,20 ,300; SQUARE , -3 ,2 ,8 ,400";
        string trimmed = String.Concat(stringInput.Where(c => !Char.IsWhiteSpace(c)));

        var listHeader = trimmed.Split(';' , ',').ToList();

        


        var input = ("SHAPE ,X ,Y , LENGTH , POINTS ; CIRCLE ,3 ,1 ,13 ,100;");


        var header = "SHAPE ,X ,Y , LENGTH , POINTS ; CIRCLE ,3 ,1 ,13 ,100;";


        //"SHAPE ,X,Y,LENGTH ,POINTS;CIRCLE ,3,1,13,100;";

        //Header
        int startIndexHeader = 0;
        int lengthIndexHeader = 23;
        String substringHeader = trimmed.Substring(startIndexHeader, lengthIndexHeader);



        var headerVariables = Regex.Split(substringHeader, @",|;");

        foreach (var vari in headerVariables)
        {
            Console.WriteLine(vari);

        }
        Console.WriteLine();
        


        //Variabler
        var startIndexVar = 24;
        var lengthIndexVar = 73;
        String substringVariables = trimmed.Substring(startIndexVar, lengthIndexVar);
        var listVariables = Regex.Split(substringVariables, @";");




        int indexLength = header.IndexOf("LENGTH");
        int indexPoints = header.IndexOf("POINTS");
        int indexX = trimmed.IndexOf("X");
        int indexY = trimmed.IndexOf("Y");
        int indexShape = trimmed.IndexOf("SHAPE");

        var lenght = listVariables[indexLength];

        var points = listVariables[indexPoints];
       


        Console.WriteLine($"{indexLength},{indexShape}, {indexX}, {indexY}, {indexPoints}");
        
        Console.WriteLine(lenght);
        Console.WriteLine(points);
        Console.WriteLine(trimmed);
    }
               
}


        //int indexShape = Array.FindIndex(header, row => row.Contains("SHAPE"));
        //int indexX = Array.FindIndex(header, row => row.Contains("X"));
        //int indexY = Array.FindIndex(header, row => row.Contains("Y"));
        //int indexPoints = Array.FindIndex(header, row => row.Contains("POINTS"));

        //Test av FindIndex med arrayer
