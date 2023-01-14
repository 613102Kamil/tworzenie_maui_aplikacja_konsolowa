// See https://aka.ms/new-console-template for more information
using RównaniaKwadratowe_Model;

Console.Write("Podaj wspolczynniki!\n\ta=");
string sa = Console.ReadLine();
Console.Write("\tb=");
string sb = Console.ReadLine();
Console.Write("\tc=");
string sc = Console.ReadLine();

Console.WriteLine($"Wprowadzone wspolczynniki: a= {sa} b= {sb} c= {sc}");
try
{
    double a = double.Parse(sa);
    double b = double.Parse(sb);
    double c = double.Parse(sc);

    RozwiązywaczRównańKwadratowych rrk = new RozwiązywaczRównańKwadratowych(a, b, c);
    Console.WriteLine(rrk.ToString() );
}
catch(Exception ex)
{
    Console.Error.WriteLine("Błąd" + ex.Message);

}