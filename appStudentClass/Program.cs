
//create an instance (object) of the Student Class
Student testStudent = new Student();

//set the properties
testStudent.Age = 56;
testStudent.FirstName = "Blaga";
testStudent.LastName = "Chongova";
Console.WriteLine(testStudent.MakeIntroduction());
class Student
{
    private string _firstName;
    private string _lastName;
    private int _age;    
    
    public string FirstName
    {
        get{ return _firstName;}
        set{ _firstName = value;}
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value;}
    }
    public int Age
    {
        get
        { return _age; }
        set { _age = value; }
    }
    //Create two Methods
    public string MakeIntroduction()
    {
        //1st way: 
        /*string introduction;
        introduction = $"My name is {_firstName} {_lastName} and I am {_age} years of age.";

        return introduction;*/
        //2nd way:
        return $"My name is {_firstName} {_lastName} and I am {_age} years of age.";
    }
}

