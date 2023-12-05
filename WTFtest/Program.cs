using System.Xml.Linq;

var x = "Hiep";
Console.WriteLine($"Hello, {x}");
//async Task tryCatch()
//{
//    try
//    {
//        var text = (await File.ReadAllTextAsync("Note.txt")).Length;
//        Console.WriteLine(text);
//        throw new Exception($"{x}");
//    }
//    catch (Exception e)
//    {
//        throw new Exception(e.Message);
//    }
//}

//await tryCatch();
string test1 = "a";
void TestIOrderedEnumerable()
{
    User newUser1 = new()
    {
        Id = Guid.NewGuid(),
        Name = "user1",
        Password = "password",
    };
    User newUser2 = new()

    {
        Id = Guid.NewGuid(),
        Name = "user2",
        Password = "password",
    };
    Console.WriteLine(newUser1.Name + "\n" + newUser1.Password + "\n" + newUser1.Id.ToString());
    Console.WriteLine("\n" + newUser2.Name + "\n" + newUser2.Password + "\n" + newUser2.Id.ToString());

    List<User> users = new List<User>();
    // users.Skip;
}


TestIOrderedEnumerable();

class User
{
    public Guid Id { get; set; }
    public required string Name { get; set; }   
    public string? Password { get; set; }
}

