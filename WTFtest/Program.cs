using static System.Console;
//void TryThrowEx()
//{
//    try
//    {
//        List<string>? a = null;
//        if (a == null) throw new ArgumentNullException();
//        int b = 5;
//        if (b == 5) throw new ArithmeticException();
//    }
//    catch (Exception)
//    {
//    }
//    finally
//    {
//        Console.WriteLine("print final");
//    }
//}
//TryThrowEx();

void NullableTest()
{
    //Nullable<int> a = null;
    //int? b = null;
    //string? c = null;
    //var s = new string('-', 20);
    User? user = null;
    WriteLine($"Name: {user?.Name?.FirstName}");
}
NullableTest();
class User
{
    public Name? Name { get; set; }
    public string? Age { get; set; }
}

class Name
{
    public String? FirstName {  get; set; }
    public string? LastName { get; set;}
}