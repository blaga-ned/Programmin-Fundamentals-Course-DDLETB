


//Student SDStudent = new Student();
//int[] studentAge = new int[3];
//Console.WriteLine( SDStudent.GetType());

//SDStudent.lastName = "Nedyalkova";
//SDStudent.firstName = "Blaga";



//Console.WriteLine($"My name is {SDStudent.firstName} {SDStudent.lastName}.");
//Console.WriteLine(SDStudent.MakeIntroduction());

Student[] SDStudents = new Student[12];

for (int i = 0; i < 12; i++)
{
    SDStudents[i] = new Student();
}
string textFileName = @"C:\Users\RM281learner10\Desktop\appStudents.txt";
string[] lines = File.ReadAllLines(textFileName);
foreach (string line in lines)
{
    Console.WriteLine(line);
}

Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();  

// adding the names in the array of SDStudents
SDStudents[0].firstName = "Blaga";
SDStudents[0].lastName = "Nedyalkova";

SDStudents[1].firstName = "Tom";
SDStudents[1].lastName = "Crofts";

SDStudents[2].firstName = "Oluwaseyi";
SDStudents[2].lastName = "Badero";

SDStudents[3].firstName = "Steph";
SDStudents[3].lastName = "Comiskey";

SDStudents[4].firstName = "Miller";
SDStudents[4].lastName = "Fernando Sargi";

SDStudents[5].firstName = "Sean";
SDStudents[5].lastName = "Grant";

SDStudents[6].firstName = "Ross";
SDStudents[6].lastName = "Lowe";

SDStudents[7].firstName = "Natalia";
SDStudents[7].lastName = "Marchi Rahal";

SDStudents[8].firstName = "Terri";
SDStudents[8].lastName = "McGurk";

SDStudents[9].firstName = "Muhammad";
SDStudents[9].lastName = "Memon";

SDStudents[10].firstName = "Ivan";
SDStudents[10].lastName = "Sedlic";

SDStudents[11].firstName = "Killian";
SDStudents[11].lastName = "Wilson";

//  1st way to print it 
for (int i = 0; i < 12; i++)
{
    Console.WriteLine(SDStudents[i].MakeIntroduction());
}
Console.WriteLine();
Console.WriteLine("-----------------------------");
Console.WriteLine();

// 2nd way to print it 

foreach(Student student in SDStudents)
{
    Console.WriteLine(student.MakeIntroduction());
}


class Student
{
    // Create some properties
    public string firstName;
    public string lastName;

    //Create some methods
    public string  MakeIntroduction()
    {
        string introduction;
        introduction = $"My name is {firstName} {lastName}.";

       return   introduction;
    }
        
    
}





