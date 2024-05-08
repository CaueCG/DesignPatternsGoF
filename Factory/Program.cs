using Factory.Factories;

/*
 * O Design Patterns Factory pertence ao grupo de padrões criacionais
 * 
 * Instanciar objetos de classes substituindo o método new Model() por um método intermediário que fará o papel de fábrica que criará estes objetos
 * Os objetos retornados do Factory Method (Fábrica) são classes concretas chamadas de "produtos"
 * 
 */


Transport transport = null;

if (args.Length > 0)
    switch (args[0])
    {
        case "--uber":
            transport = new CarTransport();
            break;
        case "--log":
            transport = new MotoTransport();
            break;
        case "--eat":
            transport = new BicycleTransport();
            break;
    }
else
    Console.WriteLine("Selecione o tipo de serviço");


if (transport != null)
{
    transport.StartTransport();
}

Console.ReadLine();