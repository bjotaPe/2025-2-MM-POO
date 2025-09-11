// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tv = new Televisao(55f);
Console.WriteLine($"A tv tem o tamanho {tv.Tamanho}");

tv.AumentarVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.DiminuirVolume();
Console.WriteLine($"Volume {tv.Volume}");

tv.AlterarMudo();
Console.WriteLine($"Volume após mute: {tv.Volume}");

tv.AlterarMudo();
Console.WriteLine($"Volume após desmute: {tv.Volume}");

tv.ProximoCanal();
Console.WriteLine($"Canal após aumentar: {tv.Canal}");

tv.CanalAnterior();
Console.WriteLine($"Canal após diminuir: {tv.Canal}");

tv.MudarCanal(100);
Console.WriteLine($"Mudar de canal direto: {tv.Canal}");

tv.MudarCanal(600);
Console.WriteLine($"Canal 600 inválido! Mantido no canal {tv.Canal}");

tv.MudarCanal(50);
tv.Desligar();
Console.WriteLine($"TV está desligada? {tv.Estado}");

tv.MudarCanal(200);
tv.Ligar();
Console.WriteLine($"Canal após ligar: {tv.Canal}");