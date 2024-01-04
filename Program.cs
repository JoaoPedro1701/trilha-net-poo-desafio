using DesafioPOO.Models;


Nokia n1 = new Nokia("45678", "C3", "345" , 64 );
Console.WriteLine("Aparelho Nokia:");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Tiktok");

Console.WriteLine("");


Console.WriteLine("Aparelho Iphone:");
Iphone ip1 = new Iphone("5678", "Iphone 5", "334678", 256);
ip1.Ligar();
ip1.ReceberLigacao();
ip1.InstalarAplicativo("FaceBook");