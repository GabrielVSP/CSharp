string fullname = "Gabriel Vergílio";
string cpf = "123-456-789.10";

Console.WriteLine(fullname.ToUpper());
Console.WriteLine(fullname.ToLower());
Console.WriteLine(cpf.Replace("-", "").Replace(".", ""));
Console.WriteLine(fullname.Length);
Console.WriteLine(fullname.Insert(fullname.Length, "."));
Console.WriteLine(fullname.Substring(0, 7));
Console.WriteLine(fullname.Substring(8));