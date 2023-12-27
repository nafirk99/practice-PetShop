// See https://aka.ms/new-console-template for more information
using LogInPractice1;



Console.WriteLine("Welcome to the Owner Portal!");


int a = LoginV2();


if(a == 1)
{
    Console.WriteLine("1. Change password");

    int choice;
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                ChangePass();
                break;

            default:
                break;

        }
    }
}

static int LoginV2()
{
    int flag = 0;
    Console.Write("Enter username: ");
    string username = Console.ReadLine();

    Console.Write("Enter password: ");
    string password = Console.ReadLine();

    using AppDbContext appDbContext = new AppDbContext();
    owner owner1 = appDbContext.Owners.Where(x => x.Id == -1).First();

    if(username == owner1.Username && password == owner1.Password)
    {
        Console.WriteLine("Logged In successfully");
        return flag = 1;
    }
    else
    {
        Console.WriteLine("LogIn Failed");
        return flag = 0;
    }

    // Student student = appDbContext.Students.Where(x => x.Id == id).FirstOrDefault();
    //owner user = owners.Find(o => o.Username == username && o.Password == password);

}

static void ChangePass()
{
    using AppDbContext context = new AppDbContext();
    owner owner = context.Owners.Where(x => x.Id == -1).First();

    Console.Write("Enter CurrentPass: ");
    string password = Console.ReadLine();

    if(password == owner.Password)
    {
        Console.WriteLine("Enter new Pass: ");
        string newPassword = Console.ReadLine();
        owner.Password = newPassword;
        context.SaveChanges();

        Console.WriteLine("Password Changed");
    }
    else
    {
        Console.WriteLine("Password Change Failed");
    }

}

 static owner Login(List<owner> owners)
{
    Console.Write("Enter username: ");
    string username = Console.ReadLine();

    Console.Write("Enter password: ");
    string password = Console.ReadLine();

    owner user = owners.Find(o => o.Username == username && o.Password == password);
    return user;
}

