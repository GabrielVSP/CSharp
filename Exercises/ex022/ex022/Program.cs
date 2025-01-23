double? x = null;
double? y = x ?? 0; 

Console.WriteLine(x.GetValueOrDefault());

Console.WriteLine(x.HasValue ? x.Value : "No value");
Console.WriteLine(y.Value);

Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);