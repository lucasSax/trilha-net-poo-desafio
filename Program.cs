
using System;

public class ItemMagico
{
    //TODO:  Crie a classe ItemMagico com os atributos nome, descrição e poder
    public string Nome;
    public string Descricao;
    public int Poder;

    public ItemMagico(string nome, string descricao, int poder)
    {
        Nome = nome;
        Descricao = descricao;
        Poder = poder;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Recebe a entrada do usuário

        string nome = Console.ReadLine();


        string descricao = Console.ReadLine();


     int poder = Convert.ToInt32(Console.ReadLine());

        // Cria o item mágico
        ItemMagico item = new ItemMagico(nome, descricao, poder);

        // Imprime o item criado
        Console.WriteLine($"Item: {item.Nome}\nDescrição: {item.Descricao}\nPoder: {item.Poder}");
    }
}


























// using DesafioPOO.Models;



// Console.WriteLine("Smatphone Nokia");
// Smartphone nokia = new Nokia(numero: "548552", modelo: "modelo 1", imei: "2222222", memoria: 64);
// nokia.Ligar();
// nokia.InstalarAplicativo("Whatsapp");

// Console.WriteLine("\n");

// Console.WriteLine("Smatphone Iphone");
// Smartphone iphone = new Iphone(numero: "984514", modelo: "modelo 2", imei: "0000", memoria: 128);
// iphone.Ligar();
// iphone.InstalarAplicativo("Telegram");

// Console.WriteLine("\n");

// TODO: Realizar os testes com as classes Nokia e Iphone

