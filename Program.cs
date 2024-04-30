using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var iphone = new Iphone("1016546", "Iphone 15", "eaf56e4f", 120);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("free fire");

var nokia = new Nokia("4598", "nokia 15", "eaf56e4f", 2);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("free fire nokia");