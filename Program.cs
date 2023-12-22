using DesafioPOO.Models;

Nokia nokia = new Nokia("00 91234-4321", "Nokia 1", "123", 2);
Iphone iphone = new Iphone("00 94321-1234", "22", "321", 8);

nokia.InstalarAplicativo("Discord");
iphone.InstalarAplicativo("Discord");

nokia.Ligar();
iphone.ReceberLigacao();