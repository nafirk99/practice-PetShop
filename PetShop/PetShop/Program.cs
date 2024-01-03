// See https://aka.ms/new-console-template for more information
using Azure;
using PetShop;
using System.Collections.Immutable;
using System.Data.Common;
using System.Xml.Serialization;

//int a = 0;
int a = LoginV2();
Console.Clear();

repeat:   // -----------------------------------
//Console.Clear();



if (a == 1)
{
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("1.  Change Your Password.");
    Console.WriteLine("2.  Add Animal Data.");
    Console.WriteLine("3.  Add Fish Data.");
    Console.WriteLine("4.  View All Animal Data In Inventory.");
    Console.WriteLine("5.  Update Animal Data.");
    Console.WriteLine("6.  View All Fish Data In Inventory.");
    Console.WriteLine("7.  Update Fish Data.");
    Console.WriteLine("8.  Feed Your Pet.");
    Console.WriteLine("9.  Update/Add pet Purchase Information.");
    Console.WriteLine("10. Sell Your Pet.");
    Console.WriteLine("11. Sales Report Analysis.");
    Console.WriteLine("12. Delete Animal Data.");
    Console.WriteLine("13. Delete Fish Data.");
    Console.WriteLine("14. Log Out.");
    Console.WriteLine("--------------------------------------------------------------------------");

    using AppDbContext dbContext = new AppDbContext();
    int choice;
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                ChangePass();
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
                int choice1 = int.Parse(Console.ReadLine());
                if (choice1 == 1)
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
                AddAnimal(dbContext);
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
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
            case 3:
                AddFish(dbContext);
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
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
            case 4:
                GetAllAnimaldata(dbContext);
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
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
            case 5:
                UpdateAnimal(dbContext);
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
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
            case 6:
                GetAllFishData(dbContext);
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
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
            case 7:
                UpdateFish(dbContext);
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
                int choice7 = int.Parse(Console.ReadLine());
                if (choice7 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>
                break;
            case 8:
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   
                Console.WriteLine("1. Feed Animal;");
                Console.WriteLine("2. Feed Fish");
                Console.WriteLine("--------------------------------------------------------------------------");
                int k = int.Parse(Console.ReadLine());
                if(k == 1)
                {
                    Console.Clear();
                    GetAllCageData(dbContext);
                    FeedCageStatusUpdate(dbContext);

                }
                else if(k ==2)
                {
                    Console.Clear();
                    GetAllAquariumData(dbContext);
                    FeedAquariumStatusUpdate(dbContext);
                }

                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
                int choice8 = int.Parse(Console.ReadLine());
                if (choice8 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>
                break;
            case 9:
                Console.WriteLine("What Do You Want to do?");
                Console.WriteLine("1. Update/Add Animal Purchase Information;");
                Console.WriteLine("2. Update/Add Fish Purchase Information");
                int l = int.Parse(Console.ReadLine());
                if (l == 1)
                {
                    Console.Clear();
                    UpdateAnimalPurchaseInfo(dbContext);
                }
                else if (l == 2)
                {
                    Console.Clear();
                    UpdateFishPurchaseInfo(dbContext);
                }
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                int choice9 = int.Parse(Console.ReadLine());
                if (choice9 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>
                break;
            case 10:
                Console.WriteLine("What Do You Want to do?");
                Console.WriteLine("1. Sell Animal");
                Console.WriteLine("2. Sell Fish");
                int m = int.Parse(Console.ReadLine());
                if (m == 1)
                {
                    Console.Clear();
                    SellAnimal(dbContext);
                    //goto repeat;
                }
                else if (m == 2)
                {
                    Console.Clear();
                    SellFish(dbContext);
                    //goto repeat;
                }
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                int choice10 = int.Parse(Console.ReadLine());
                if (choice10 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>
                break;
            case 11:
                SalesRepport(dbContext);
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                int choice11 = int.Parse(Console.ReadLine());
                if (choice11 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>
                break;
            case 12:
                DeleteAnimal(dbContext);
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
                int choice12 = int.Parse(Console.ReadLine());
                if (choice12 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>
                break;
            case 13:
                DeleteFish(dbContext);
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("What Do You Want to do?");   //>>>
                Console.WriteLine("1. Go To main Option");
                Console.WriteLine("2. Exit");
                Console.WriteLine("--------------------------------------------------------------------------");
                int choice13 = int.Parse(Console.ReadLine());
                if (choice13 == 1)
                {
                    Console.Clear();
                    goto repeat;  //---------------------------------
                }
                else
                {
                    Console.WriteLine("Exiting");
                }                                               //>>
                break;
            case 14:
                Console.Clear();
                Console.WriteLine("Logging Out");
                break;

            default:
                Console.WriteLine("Invalid option.");
                break;

        }
    }
}



static int LoginV2()
{
    Console.WriteLine("***************************");
    Console.WriteLine("*  |Welcome to Pet Shop|  *");
    Console.WriteLine("***************************");

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
static void GetAllAnimaldata(AppDbContext dbContext)
{
    //using AppDbContext appDbContext = new AppDbContext();
    List<Animal> animals = dbContext.Animals.ToList();
    Console.WriteLine("--------------------------------------------------------------------------");
    foreach (Animal animal in animals)
    {
        //Console.WriteLine($"|Id: {animal.Id}\t|Species: {animal.Species}\t|Age:{animal.Age}\t|Purchase Price: {animal.PurchasePrice}\t|SellerId: {animal.SellerId}|");
        Console.WriteLine($"|Id: {animal.Id,-10}|Species: {animal.Species,-10}|Age: {animal.Age,-10}|Purchase Price: {animal.PurchasePrice,-10}|SellerId: {animal.SellerId,-10}|");

    }
    Console.WriteLine("--------------------------------------------------------------------------");
}

static void UpdateAnimal(AppDbContext dbContext)
{
    // Show All Animal
    List<Animal> a1 = dbContext.Animals.ToList();
    Console.WriteLine("--------------------------------------------------------------------------");
    foreach (Animal a in a1)
    {
            Console.WriteLine($"|Id: {a.Id, -10}|Species: {a.Species,-10}|Age: {a.Age,-10}|Purchase Price: {a.PurchasePrice,-10}|SellerId: {a.SellerId,-10}|");
    }
    Console.WriteLine("--------------------------------------------------------------------------");

    Console.Write("Which Animal You want to Update(Id): ");
    int id = int.Parse(Console.ReadLine());


    Animal animal = dbContext.Animals.Where(x => x.Id == id).FirstOrDefault();

    Console.WriteLine($"Details of Animal Id: {animal.Id}");
    Console.WriteLine($"|Id: {animal.Id,-10}|Species: {animal.Species,-10}|Age: {animal.Age,-10}|Purchase Price: {animal.PurchasePrice,-10}|SellerId: {animal.SellerId,-10}|");

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

static void GetAllFishData(AppDbContext dbContext)
{
    List<Fish> fishes = dbContext.Fishes.ToList();
    Console.WriteLine("--------------------------------------------------------------------------");
    foreach (Fish fish in fishes)
    {
        Console.WriteLine($"|Id: {fish.Id,-10}|Species: {fish.Species,-10}|Age: {fish.Age,-10}|Purchase Price: {fish.PurchasePrice,-10}|SellerId: {fish.SellerId,-10}|");
    }
    Console.WriteLine("--------------------------------------------------------------------------");
}

static void UpdateFish(AppDbContext dbContext)
{
    // Show All Fish
    List<Fish> f1 = dbContext.Fishes.ToList();
    Console.WriteLine("--------------------------------------------------------------------------");
    foreach (Fish f in f1)
    {
        Console.WriteLine($"|Id: {f.Id,-10}|Species: {f.Species,-10}|Age: {f.Age,-10}|Purchase Price: {f.PurchasePrice,-10}|SellerId: {f.SellerId,-10}|");
    }
    Console.WriteLine("--------------------------------------------------------------------------");

    Console.Write("Which Fish You want to Update(Id): ");
    int id = int.Parse(Console.ReadLine());


    Fish fish = dbContext.Fishes.Where(x => x.Id == id).FirstOrDefault();

    Console.WriteLine($"Details of Fish Id: {fish.Id}");
    Console.WriteLine($"|Id: {fish.Id,-10}|Species: {fish.Species,-10}|Age: {fish.Age,-10}|Purchase Price: {fish.PurchasePrice,-10}|SellerId: {fish.SellerId,-10}|");

    // Specie Update
    Console.Write("Enter Updated Specie: ");
    fish.Species = Console.ReadLine();

    // Age Update
    Console.Write("Enter Updated Age: ");
    fish.Age = int.Parse(Console.ReadLine());

    // Purchase Price Update
    Console.Write("Enter Updated Purchase Price: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal updatedPrice))
    {
        fish.PurchasePrice = updatedPrice;
    }
    else
    {
        Console.Write("Invalid price Input. Using Existing Value");
    }
    dbContext.SaveChanges();
    Console.WriteLine("Animal Updated Successfully.");
}

static void GetAllCageData(AppDbContext dbContext)
{
    List<Cage> cages = dbContext.Cages.ToList();
    Console.WriteLine("--------------------------------------------------------------------------");
    foreach (Cage cage in cages)
    {
        Console.WriteLine($"|Id: {cage.Id,-10}|Feeding Status: {cage.FeedingStatus,-10}|");
    }
    Console.WriteLine("--------------------------------------------------------------------------");
}

static void FeedCageStatusUpdate(AppDbContext dbContext)
{
    Console.Write("Which Cage Do you Want to feed(Id): ");
    int id = int.Parse(Console.ReadLine());

    Cage cage = dbContext.Cages.Where(x => x.Id == id).FirstOrDefault();

    // Feeding Status Update
    Console.Write("Enter Updated Feeding Status(Yes/No) and (Time in String): ");
    cage.FeedingStatus = Console.ReadLine();
    dbContext.SaveChanges();
   
}

static void GetAllAquariumData(AppDbContext dbContext)
{
    List<Aquarium> aquariums = dbContext.Aquariums.ToList();
    Console.WriteLine("--------------------------------------------------------------------------");
    foreach (Aquarium aqurium in aquariums)
    {
        Console.WriteLine($"|Id: {aqurium.Id,-10}|Feeding Status: {aqurium.FeedingStatus,-10}|");
    }
    Console.WriteLine("--------------------------------------------------------------------------");
}

static void FeedAquariumStatusUpdate(AppDbContext dbContext)
{
    Console.Write("Which Aquarium Do you Want to feed(Id): ");
    int id = int.Parse(Console.ReadLine());

    Aquarium aquarium = dbContext.Aquariums.Where(x => x.Id == id).FirstOrDefault();

    // Feeding Status Update
    Console.Write("Enter Updated Feeding Status(Yes/No) and (Time in String): ");
    aquarium.FeedingStatus = Console.ReadLine();
    dbContext.SaveChanges();
}

static void UpdateAnimalPurchaseInfo(AppDbContext dbContext)
{
    Console.Write("Which Animal's Purchase Info You want to Update(Id): ");
    int id = int.Parse(Console.ReadLine());


    Animal animal = dbContext.Animals.Where(x => x.Id == id).FirstOrDefault();
    Seller seller = dbContext.Sellers.Where(x => x.Id == animal.SellerId).FirstOrDefault();

    Console.WriteLine($"Details of Animal Id: {animal.Id}");
    Console.WriteLine($"|SellerId: {animal.SellerId,-10}|Seller Name: {seller.Name,-10}|Seller Contact: {seller.Contact,-10}|Purchase Price: {animal.PurchasePrice,-10}|");

    // Seller name Update
    Console.Write("Enter Updated Seller Name: ");
    seller.Name = Console.ReadLine();

    // Seller Contact Update
    Console.Write("Enter Updated Seller Contact: ");
    seller.Contact = Console.ReadLine();

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

static void UpdateFishPurchaseInfo(AppDbContext dbContext)
{
    Console.Write("Which Fish's Purchase Info You want to Update(Id): ");
    int id = int.Parse(Console.ReadLine());


    Fish fish = dbContext.Fishes.Where(x => x.Id == id).FirstOrDefault();
    Seller seller = dbContext.Sellers.Where(x => x.Id == fish.SellerId).FirstOrDefault();

    Console.WriteLine($"Details of Animal Id: {fish.Id}");
    Console.WriteLine($"|SellerId: {fish.SellerId,-10}|Seller Name: {seller.Name,-10}|Seller Contact: {seller.Contact,-10}|Purchase Price: {fish.PurchasePrice,-10}|");

    // Seller name Update
    Console.Write("Enter Updated Seller Name: ");
    seller.Name = Console.ReadLine();

    // Seller Contact Update
    Console.Write("Enter Updated Seller Contact: ");
    seller.Contact = Console.ReadLine();

    // Purchase Price Update
    Console.Write("Enter Updated Purchase Price: ");
    if (decimal.TryParse(Console.ReadLine(), out decimal updatedPrice))
    {
        fish.PurchasePrice = updatedPrice;
    }
    else
    {
        Console.Write("Invalid price Input. Using Existing Value");
    }
    dbContext.SaveChanges();
    Console.WriteLine("Animal Updated Successfully.");
}

static void SellAnimal(AppDbContext dbContext)
{
    Console.Write("Which Animal You want to Sell(Id): ");
    int id = int.Parse(Console.ReadLine());

    Animal animal = dbContext.Animals.Where(x => x.Id == id).FirstOrDefault();
    SellRecord sellRecord = new SellRecord();

    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine($"Id: |{animal.Id,-10}|Species: {animal.Species,-10}|Age: {animal.Age,-10}|Purchase Price: {animal.PurchasePrice,-10}|Seller Id: {animal.SellerId,-10}|Cage Id: {animal.CageId,-10}|");
    Console.WriteLine("--------------------------------------------------------------------------");

    // Sell Price
    Console.Write("Enter Sell Price: ");
    int sellPrice = int.Parse(Console.ReadLine());
    sellRecord.Species = animal.Species;
    sellRecord.PurchasePrice = animal.PurchasePrice;
    sellRecord.SellPrice = sellPrice;

    // Sell Date
    // Take input from the user for Sell Date
    Console.Write("Enter Sell Date (yyyy<space>MM<space>dd): ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime dos))
    {
        sellRecord.SellDate = dos;
    }
    else
    {
        Console.WriteLine("Invalid Date input. Using default value (01/01/0001)");
        sellRecord.SellDate = new DateTime(1, 1, 1);
    }
    dbContext.SellRecords.Add(sellRecord);
    dbContext.Animals.Remove(animal);
    dbContext.SaveChanges();
    


}

static void SellFish(AppDbContext dbContext)
{
    Console.Write("Which Fish You want to Sell(Id): ");
    int id = int.Parse(Console.ReadLine());

    Fish fish = dbContext.Fishes.Where(x => x.Id == id).FirstOrDefault();
    SellRecord sellRecord = new SellRecord();

    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine($"Id: |{fish.Id,-10}|Species: {fish.Species,-10}|Age: {fish.Age,-10}|Purchase Price: {fish.PurchasePrice,-10}$|Seller Id: {fish.SellerId,-10}|Aquarium Id: {fish.AquariumId,-10}|");
    Console.WriteLine("--------------------------------------------------------------------------");

    // Sell Price
    Console.Write("Enter Sell Price: ");
    int sellPrice = int.Parse(Console.ReadLine());
    sellRecord.Species = fish.Species;
    sellRecord.PurchasePrice = fish.PurchasePrice;
    sellRecord.SellPrice = sellPrice;

    // Sell Date
    // Take input from the user for Sell Date
    Console.Write("Enter Sell Date (yyyy<space>MM<space>dd): ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime dos))
    {
        sellRecord.SellDate = dos;
    }
    else
    {
        Console.WriteLine("Invalid Date input. Using default value (01/01/0001)");
        sellRecord.SellDate = new DateTime(1, 1, 1);
    }
    dbContext.SellRecords.Add(sellRecord);
    dbContext.Fishes.Remove(fish);
    dbContext.SaveChanges();
}

static void SalesRepport(AppDbContext dbContext)
{
    decimal totalPurchase = 0m;
    decimal totalSell = 0m;

    Console.WriteLine("Purchase Record");
    List<Animal> animals = dbContext.Animals.ToList();
    List<Fish> fishes = dbContext.Fishes.ToList();

    Console.WriteLine("--------------------------------------------------------------------------");
    foreach (Animal animal in animals)
    {
        Console.WriteLine($"|Id: {animal.Id,-3}|Species: {animal.Species,-10}|Purcahse Price: {animal.PurchasePrice,-10}$|");
    }
    foreach(Fish fish in fishes)
    {
        Console.WriteLine($"|Id: {fish.Id,-3}|Species: {fish.Species,-10}|Purcahse Price: {fish.PurchasePrice,-10}$|");
    }
    Console.WriteLine("--------------------------------------------------------------------------");

    Console.WriteLine("Sales Record");
    List<SellRecord> sellRecords= dbContext.SellRecords.ToList();

    Console.WriteLine("--------------------------------------------------------------------------");
    foreach (SellRecord sellr in sellRecords)
    {
        Console.WriteLine($"|Sell Id: {sellr.Id,-3}|Species: {sellr.Species,-10}|Purchase Price: {sellr.PurchasePrice,-10}|Sell Price: {sellr.SellPrice,-10}|Sell Date: {sellr.SellDate.ToShortDateString(),-10}|");
        totalPurchase += sellr.PurchasePrice;
        totalSell += sellr.SellPrice;
    }
    Console.WriteLine("--------------------------------------------------------------------------");

    if (totalSell > totalPurchase)
    {
        decimal p = totalSell - totalPurchase;
        Console.WriteLine($"Total Profit: {p}");
    }
    else if (totalPurchase > totalSell)
    {
        decimal p = totalPurchase - totalSell;
        Console.WriteLine($"Totall Loss: {p}");
    }
    else
    {
        Console.WriteLine($"No Loss No Profit");
        Console.WriteLine($"Total Purchase: {totalPurchase}");
        Console.WriteLine($"Total Sell:     {totalSell}");
    }
    
    
}

static void DeleteAnimal(AppDbContext dbContext)
{
    List<Animal> animals = dbContext.Animals.ToList();
    Console.WriteLine("--------------------------------------------------------------------------");
    foreach (Animal animal in animals)
    {
        Console.WriteLine($"|Id: {animal.Id,-10}|Species: {animal.Species,-10}|Age: {animal.Age,-10}|Purchase Price: {animal.PurchasePrice,-10}|SellerId: {animal.SellerId,-10}|");
    }
    Console.WriteLine("--------------------------------------------------------------------------");

    Console.Write("Which Animal Data You want to Delete(Id): ");
    int id = int.Parse(Console.ReadLine());

    Animal animal1 = dbContext.Animals.Where(x => x.Id == id ).FirstOrDefault();
    dbContext.Animals.Remove(animal1);
    dbContext.SaveChanges();
}

static void DeleteFish(AppDbContext dbContext)
{
    List<Fish> fish = dbContext.Fishes.ToList();
    Console.WriteLine("--------------------------------------------------------------------------");
    foreach(Fish fish1 in fish)
    {
        Console.WriteLine($"|Id: {fish1.Id,-10}|Species: {fish1.Species,-10}|Age: {fish1.Age,-10}|Purchase Price: {fish1.PurchasePrice,-10}|SellerId: {fish1.SellerId,-10}|");
    }
    Console.WriteLine("--------------------------------------------------------------------------");

    Console.Write("Which Fish Data You want to Delete(Id): ");
    int id = int.Parse(Console.ReadLine());

    Fish fish2 = dbContext.Fishes.Where(x => x.Id == id).FirstOrDefault();
    dbContext.Fishes.Remove(fish2);
    dbContext.SaveChanges();
}
