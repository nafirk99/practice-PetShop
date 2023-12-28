// See https://aka.ms/new-console-template for more information
using LogInPractice1;



Console.WriteLine("Welcome to the Owner Portal!");


int a = LoginV2();


if(a == 1)
{
    Console.WriteLine("1. Change password");
    Console.WriteLine("2. Add Animal");
    Console.WriteLine("3. Add Fish");
    Console.WriteLine("4. View All Animaldata");
    Console.WriteLine("5. Update Animal Data");

    using AppDbContext dbContext = new AppDbContext();
    int choice;
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                ChangePass();
                break;
            case 2:
                AddAnimal(dbContext);
                break;
            case 3:
                AddFish(dbContext);
                break;
            case 4:
                GetAllAnimaldata(dbContext);
                break;
            case 5:
                UpdateAnimal(dbContext);
                break;
            case 6:
                //GetAllAnimaldata(dbContext);
                break;
            case 7:
                //GetAllAnimaldata(dbContext);
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

//----------------------------

static void AddAnimal(AppDbContext dbContext)
{
    Animal animal = new Animal();

    // Prompt for seller information
    Seller seller = GetSellerInformation(dbContext);
    animal.Seller = seller;

    // Prompt for cage information
    Cage cage = GetCageInformation(dbContext);
    animal.Cage = cage;

    Console.Write("Enter species: ");
    animal.Species = Console.ReadLine();

    Console.Write("Enter age: ");
    if (int.TryParse(Console.ReadLine(), out int age))
    {
        animal.Age = age;
    }
    else
    {
        Console.WriteLine("Invalid age input. Using default value 0.");
        animal.Age = 0;
    }

    Console.Write("Enter purchase price: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal purchasePrice))
    {
        animal.PurchasePrice = purchasePrice;
    }
    else
    {
        Console.WriteLine("Invalid purchase price input. Using default value 0.0");
        animal.PurchasePrice = 0.0m;
    }

    // Similar steps for other properties...

    dbContext.Animals.Add(animal);
    dbContext.SaveChanges();

    Console.WriteLine("Animal added to the database successfully.");
}
static void AddFish(AppDbContext dbContext)
{
    Fish fish = new Fish();

    // Prompt for seller information
    Seller seller = GetSellerInformation(dbContext);
    fish.Seller = seller;

    // Prompt for aquarium information
    Aquarium aquarium = GetAquariumInformation(dbContext);
    fish.Aquarium = aquarium;

    Console.Write("Enter species: ");
    fish.Species = Console.ReadLine();

    Console.Write("Enter age: ");
    if (int.TryParse(Console.ReadLine(), out int age))
    {
        fish.Age = age;
    }
    else
    {
        Console.WriteLine("Invalid age input. Using default value 0.");
        fish.Age = 0;
    }

    Console.Write("Enter purchase price: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal purchasePrice))
    {
        fish.PurchasePrice = purchasePrice;
    }
    else
    {
        Console.WriteLine("Invalid purchase price input. Using default value 0.0");
        fish.PurchasePrice = 0.0m;
    }

    // Similar steps for other properties...

    dbContext.Fishes.Add(fish);
    dbContext.SaveChanges();

    Console.WriteLine("Fish added to the database successfully.");
}

static Seller GetSellerInformation(AppDbContext dbContext)
{
    Seller seller = new Seller();

    Console.Write("Enter seller name: ");
    seller.Name = Console.ReadLine();

    Console.Write("Enter seller contact: ");
    seller.Contact = Console.ReadLine();

    dbContext.Sellers.Add(seller);
    dbContext.SaveChanges();

    return seller;
}

static Cage GetCageInformation(AppDbContext dbContext)
{
    Cage cage = new Cage();

    Console.Write("Enter feeding status for the cage: ");
    cage.FeedingStatus = Console.ReadLine();

    dbContext.Cages.Add(cage);
    dbContext.SaveChanges();

    return cage;
}

static Aquarium GetAquariumInformation(AppDbContext dbContext)
{
    Aquarium aquarium = new Aquarium();

    Console.Write("Enter feeding status for the aquarium: ");
    aquarium.FeedingStatus = Console.ReadLine();

    dbContext.Aquariums.Add(aquarium);
    dbContext.SaveChanges();

    return aquarium;
}

static void GetAllAnimaldata(AppDbContext dbContext)
{
    //using AppDbContext appDbContext = new AppDbContext();
    List<Animal> animals =dbContext.Animals.ToList();

    foreach (Animal animal in animals)
    {
        Console.WriteLine($"|Id: {animal.Id}|Species: {animal.Species}|Age: {animal.Age}|Purchase Price: {animal.PurchasePrice}|SellerId: {animal.SellerId}|");
    }
}

static void UpdateAnimal(AppDbContext dbContext)
{
    Console.Write("Which Animal You want to Update(Id): ");
    int id = int.Parse(Console.ReadLine());

   
    Animal animal = dbContext.Animals.Where(x => x.Id == id).FirstOrDefault();

    Console.WriteLine($"Details of Animal Id: {animal.Id}");
    Console.WriteLine($"|Id: {animal.Id}|Species: {animal.Species}|Age: {animal.Age}|Purchase Price: {animal.PurchasePrice}|SellerId: {animal.SellerId}|");

    // Specie Update
    Console.Write("Enter Updated Specie: ");
    animal.Species = Console.ReadLine();

    // Age Update
    Console.Write("Enter Updated Age: ");
    animal.Age = int.Parse(Console.ReadLine());

   // Purchase Price Update
   Console.Write("Enter Updated Purchase Price: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal updatedPrice))
    {
        animal.PurchasePrice = updatedPrice;
    }
    else
    {
        Console.Write("Invalid price Input. Using Existing Value");
    }
    dbContext.SaveChanges();
    Console.WriteLine("Animal Updated Successfully.");

}