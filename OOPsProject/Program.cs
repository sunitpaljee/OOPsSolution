using OOPsProject;

Console.WriteLine("Hello, World!");
Student s1= new Student(101);

Student s2 = new Student(102)
{
    SName="Aman",
    Address = "Kanpur",
    Fee = 30000f,
    ISActive =true
};
Student s3 = new Student(103)
{
    SName = "Swathi",
    Address = "Tumkur",
    Fee = 15000f,
    ISActive = false
};
Student s4 = new Student(104)
{
    SName = "Muizun",
    Address = "MySore",
    Fee = 40000f,
    ISActive = false
};

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);

