var x = "abc";
Console.WriteLine($"Hello, World! {x}");
void tryCatch()
{
    try
    {
        Console.WriteLine("abcccc");
        throw new Exception($"{x}");  
    }
    catch(Exception e)
    {
        throw new Exception(e.Message);
    }
}
tryCatch();