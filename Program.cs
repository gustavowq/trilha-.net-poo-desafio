using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia InstalApp = new Nokia();
Iphone InstallAppIP = new Iphone();

Console.WriteLine("TESTANDO METODOS NOKIA");
InstalApp.Ligar();
InstalApp.ReceberLigacao();
InstalApp.InstalarAplicativo("LINKEDIN");



Console.WriteLine("TESTANDO METODOS IPHONE");
InstallAppIP.Ligar();
InstallAppIP.ReceberLigacao();
InstallAppIP.InstalarAplicativo("GLASSDOR");


