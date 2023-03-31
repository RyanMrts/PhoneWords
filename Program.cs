

string frase, frasealterada;

Console.Write("Conversor de Phone Words: ");

frase = Console.ReadLine()!;

frasealterada = frase

.Replace("A", "2" )     .Replace("D", "3" )     .Replace("G", "4" )     .Replace("J", "5" )     .Replace("M", "6" )     .Replace("T", "8" )
.Replace("a", "2" )     .Replace("d", "3" )     .Replace("g", "4" )     .Replace("j", "5" )     .Replace("m", "6" )     .Replace("t", "8" )
.Replace("B", "2" )     .Replace("E", "3" )     .Replace("H", "4" )     .Replace("K", "5" )     .Replace("N", "6" )     .Replace("U", "8" )
.Replace("b", "2" )     .Replace("e", "3" )     .Replace("h", "4" )     .Replace("k", "5" )     .Replace("n", "6" )     .Replace("u", "8" )
.Replace("C", "2" )     .Replace("F", "3" )     .Replace("l", "4" )     .Replace("L", "5" )     .Replace("O", "6" )     .Replace("V", "8" )
.Replace("c", "2" )     .Replace("f", "3" )     .Replace("i", "4" )     .Replace("l", "5" )     .Replace("o", "6" )     .Replace("v", "8" )


.Replace("P", "7" ) .Replace("W", "9" )
.Replace("p", "7" ) .Replace("w", "9" )
.Replace("Q", "7" ) .Replace("X", "9" )
.Replace("q", "7" ) .Replace("x", "9" )
.Replace("R", "7" ) .Replace("Y", "9" )
.Replace("r", "7" ) .Replace("y", "9" )
.Replace("S", "7" ) .Replace("Z", "9" )
.Replace("s", "7" ) .Replace("z", "9" );


Console.WriteLine(frase);

Console.WriteLine(frasealterada);






