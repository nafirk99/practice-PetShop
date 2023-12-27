// See https://aka.ms/new-console-template for more information
using EntityPractice2;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

int a = LoginV2();
Console.Clear();

repeat:   // -----------------------------------
//Console.Clear();

if (a == 1)
{
    Console.WriteLine("What Do You Want to do?");
    Console.WriteLine("1. Add Student Data");
    Console.WriteLine("2. View All Student List");
    Console.WriteLine("3. Delete a Stdent");
    Console.WriteLine("4. Update a Stdent");
    Console.WriteLine("5. Change Pass");
    Console.WriteLine("6. Log Out");

    int choice;
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                AddStudent();

                Console.WriteLine("What Do You Want to do?");   //>>>
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
                }                                               //>>

                break;
            case 2:
                ViewAllStudent();

                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                int choice3 = int.Parse(Console.ReadLine());
                if (choice3 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>

                break;
            case 3:
                DeleteAStudent();

                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                int choice4 = int.Parse(Console.ReadLine());
                if (choice4 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>
                break;
            case 4:
                UpdateStudentV2();
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                int choice5 = int.Parse(Console.ReadLine());
                if (choice5 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>
                break;

            case 5:
                ChangePass();
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                int choice6 = int.Parse(Console.ReadLine());
                if (choice6 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>

                break;
            case 6:
                Console.WriteLine("Logging Out");
                goto exiting;
                break;

            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

}

else { Console.WriteLine("Log In Failed"); }

exiting:
//Console.Clear();
Console.WriteLine("Logged Out");
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

    using AppDbContext appDbContext = new AppDbContext();
    appDbContext.Students.Add(student);
    appDbContext.SaveChanges();

    Console.WriteLine("Student Added To dataBase Successfully.");
}
static void ViewAllStudent()
{
    using AppDbContext appDbContext = new AppDbContext();
    List<Student> students = appDbContext.Students.ToList();

    foreach (Student student in students)
    {
        Console.WriteLine($"Id: {student.Id} Name: {student.Name} Cgpa: {student.Cgpa} DateOfBirth: {student.DateOfBirth.ToShortDateString()}");
    }
}
static void DeleteAStudent()
{
    Console.Write("Which student u want to delete(Id): ");
    int id = int.Parse(Console.ReadLine());

    using AppDbContext appDbContext = new AppDbContext();
    Student student = appDbContext.Students.Where(x => x.Id == id).FirstOrDefault();
    
    if (student != null)
    {
        appDbContext.Students.Remove(student);
        appDbContext.SaveChanges();
    }

}
static void UpdateStudent()
{
    // Take input from the user for the student's ID to update
    Console.Write("Enter student ID to update: ");
    if (!int.TryParse(Console.ReadLine(), out int studentId))
    {
        Console.WriteLine("Invalid student ID input.");
        return;
    }

    // Create an instance of the DbContext
    using (AppDbContext appDbContext = new AppDbContext())
    {
        // Find the student with the specified ID
        Student studentToUpdate = appDbContext.Students.Find(studentId);

        if (studentToUpdate == null)
        {
            Console.WriteLine($"Student with ID {studentId} not found.");
            return;
        }

        // Display the current student information
        Console.WriteLine($"Current Student Information:");
        Console.WriteLine($"Name: {studentToUpdate.Name}");
        Console.WriteLine($"Cgpa: {studentToUpdate.Cgpa}");
        Console.WriteLine($"Date of Birth: {studentToUpdate.DateOfBirth.ToShortDateString()}");

        // Take input from the user for updated information

        Console.Write("Enter updated student Name: ");
        studentToUpdate.Name = Console.ReadLine();

        Console.Write("Enter updated student Cgpa: ");
        if (double.TryParse(Console.ReadLine(), out double updatedCgpa))
        {
            studentToUpdate.Cgpa = updatedCgpa;
        }
        else
        {
            Console.WriteLine("Invalid Cgpa input. Using existing value.");
        }

        Console.Write("Enter updated student Date of Birth (yyyy-MM-dd): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime updatedDob))
        {
            studentToUpdate.DateOfBirth = updatedDob;
        }
        else
        {
            Console.WriteLine("Invalid Date of Birth input. Using existing value.");
        }

        // Save changes to the database
        appDbContext.SaveChanges();

        Console.WriteLine("Student Updated Successfully.");
    }
}
static void UpdateStudentV2()
{
    Console.Write("Which student u want to Update(Id): ");
    int id = int.Parse(Console.ReadLine());

    using AppDbContext appDbContext = new AppDbContext();
    Student student = appDbContext.Students.Where(x => x.Id == id).FirstOrDefault();

    Console.WriteLine($"Details of Student Id: {student.Id}");
    Console.WriteLine($"Id: {student.Id} Name: {student.Name} Cgpa: {student.Cgpa} DateOfBirth: {student.DateOfBirth.ToShortDateString()}");

    // Name Update
    Console.Write("Enter Updated student Name: ");
    student.Name = Console.ReadLine();

    // Cgpa Update
    Console.Write("Enter Updated student Cgpa: ");
    if(double.TryParse(Console.ReadLine(), out double updatedCgpa))
    {
        student.Cgpa = updatedCgpa;
    }
    else
    {
        Console.Write("Invalid Cgpa Input. Using Existing Value");
    }

    // DateOfBirth Update
    Console.Write("Enter Updated DateOfBirth: ");
    if(DateTime.TryParse(Console.ReadLine(), out DateTime updatedDate))
    {
        student.DateOfBirth = updatedDate;
    }

    appDbContext.SaveChanges();
    Console.WriteLine("Student Updated Successfully.");

}
static int LoginV2()
{
    int flag = 0;
    Console.Write("Enter username: ");
    string username = Console.ReadLine();

    Console.Write("Enter password: ");
    string password = Console.ReadLine();

    Console.Clear();

    using AppDbContext appDbContext = new AppDbContext();
    owner owner1 = appDbContext.Owners.Where(x => x.Id == -1).First();

    if (username == owner1.Username && password == owner1.Password)
    {
        Console.WriteLine("Logged In successfully");
        return flag = 1;
    }
    else
    {
        Console.WriteLine("LogIn Failed");
        return flag = 0;
        
    }
    
}
static void ChangePass()
{
    using AppDbContext context = new AppDbContext();
    owner owner = context.Owners.Where(x => x.Id == -1).First();

    Console.Write("Enter CurrentPass: ");
    string password = Console.ReadLine();

    Console.Clear();

    if (password == owner.Password)
    {
        Console.Write("Enter new Pass: ");
        string newPassword = Console.ReadLine();
        owner.Password = newPassword;
        context.SaveChanges();

        Console.Clear();

        Console.WriteLine("Password Changed");
    }
    else
    {
        Console.WriteLine("Password Change Failed");
    }

}


