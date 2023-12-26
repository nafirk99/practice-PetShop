// See https://aka.ms/new-console-template for more information
using EntityPractice2;

repeat:   // -----------------------------------
//Console.Clear();

Console.WriteLine("What Do You Want to do?");
Console.WriteLine("1. Add Student Data");
Console.WriteLine("2. Logout");
Console.WriteLine("3. Exit");

int choice;
if (int.TryParse(Console.ReadLine(), out choice))
{
    switch (choice)
    {
        case 1:
            AddStudent();

            Console.WriteLine("What Do You Want to do?");
            Console.WriteLine("1. Go To main Option");
            Console.WriteLine("2. Exit");
            int choice2 = int.Parse(Console.ReadLine());
            if (choice2 == 1)
            {
                Console.Clear();
                goto repeat;  //---------------------------------
            }
            else
            {
                Console.WriteLine("Exiting");
            }

            break;
        case 2:
            Console.WriteLine("Lorem ipsum");
            
            break;
        case 3:
            Console.WriteLine("Lorem ipsum");

            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}

//repeat:

//goto repeat;

static void AddStudent()
{
    // Create a new student instance
    Student student = new Student();

    // Take input from the user for Name
    Console.Write("Enter student Name: ");
    student.Name = Console.ReadLine();

    // Take input from the user for Cgpa
    Console.Write("Enter student Cgpa: ");
    // Use double.TryParse to handle invalid input
    if (double.TryParse(Console.ReadLine(), out double cgpa))
    {
        student.Cgpa = cgpa;
    }
    else
    {
        Console.WriteLine("Invalid Cgpa input. Using default value 0.0");
        student.Cgpa = 0.0;
    }

    // Take input from the user for DateOfBirth
    Console.Write("Enter student Date of Birth (yyyy-MM-dd): ");
    // Use DateTime.TryParse to handle invalid input
    if (DateTime.TryParse(Console.ReadLine(), out DateTime dob))
    {
        student.DateOfBirth = dob;
    }
    else
    {
        Console.WriteLine("Invalid Date of Birth input. Using default value (01/01/0001)");
        student.DateOfBirth = new DateTime(1, 1, 1);
    }

    AppDbContext appDbContext = new AppDbContext();
    appDbContext.Students.Add(student);
    appDbContext.SaveChanges();

    Console.WriteLine("Student Added To dataBase Successfully.");
}



