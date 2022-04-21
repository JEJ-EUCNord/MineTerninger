using Maskine;
// Lav nye terninger
Terning terning1 = new Terning();
Terning terning2 = new Terning();
// Initialiser terningerne
terning1.AntalSider = 6;
terning2.AntalSider = 69;
// Kast med terningerne
terning1.Kast();
terning2.Kast();
// Udskriv resultat

Console.Write(terning1.Værdi);
Console.Write(" ");
Console.Write(terning2.Værdi);
Console.Write(" ");
Console.WriteLine(terning1.Værdi + terning2.Værdi);
