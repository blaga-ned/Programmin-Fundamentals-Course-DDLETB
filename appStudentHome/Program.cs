

/*StudentV2 SDStudent = new StudentV2();
SDStudent.SetFirstName("bLaga");
SDStudent.SetLastName("Nedyalkova");

Console.WriteLine(SDStudent.GetFirstName());
Console.WriteLine(SDStudent.GetLastName());
Console.WriteLine(SDStudent.MakeIntroduction())*/

StudentV3 SDStudent = new StudentV3();
SDStudent.Age = 56;
SDStudent.firstNameV3 = "bLAGA nEDYalkova";

Console.WriteLine(SDStudent.Age);
Console.WriteLine(SDStudent.firstNameV3);
/*
class StudentV2
{
    //Encapsulataion
    private string firstNameV2;
    private string lastNameV2;

    //Setter and Getter for the firstName

    public void SetFirstName(string firstNameV2)
    {
        this.firstNameV2 = char.ToUpper(firstNameV2[0]) + firstNameV2.Substring(1).ToLower();
                
            }

    public string GetFirstName()
    {
        return this.firstNameV2;
    }
    //Setter and Getter for the lastName
    public void SetLastName(string lastNameV2)
    {
        this.lastNameV2 = lastNameV2;
    }

    public string GetLastName()
    {
        return this.lastNameV2;
    }
    public string MakeIntroduction()
    {
        string introduction;
        introduction = $"My name is {this.firstNameV2} {this.lastNameV2}.";

        return introduction;
    }

}*/

class StudentV3
{
    private int age;
    private string firstName;
    
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
           age = value;
         
            
        }
    }
    public string firstNameV3
    {
        set
        {
            firstName = value.ToUpper();
        }
        get
        {
            return firstName;
        }
        
    }
}
