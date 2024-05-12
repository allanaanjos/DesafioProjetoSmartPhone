
using DesafioProjetoCelular.Models;

Console.WriteLine("------------SmartPhone Nokia----------------");

Nokia NokiaPhone = new Nokia( "13991876543", "ntr453", "00567392ty47", 4);

Console.WriteLine(NokiaPhone.InstalarAplicativo("GPS"));

NokiaPhone.Ligar();

NokiaPhone.ReceberLigacao();

Console.WriteLine("------------SmartPhone Iphone----------------");

Iphone iphone = new Iphone("13997415367", "Iphone-15", "000348756w8b4t", 8);

Console.WriteLine(iphone.InstalarAplicativo("GPS"));

iphone.Ligar();

iphone.ReceberLigacao();