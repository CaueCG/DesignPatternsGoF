using AbstractFactory.App;
using AbstractFactory.Factories;

static App ConfigureApplication()
{
    App app;

    ITransportFactory transportFactory = null;
    string company = "James";

    switch (company)
    {
        case "Uber":
            transportFactory = new UberTransport();
            break;
        case "NineNine":
            transportFactory = new NineNineTransport();
            break;
        case "James":
            transportFactory = new JamesTransport();
            break;
    }

    app = new App(transportFactory);

    return app;
}

App app = ConfigureApplication();

app.StartRoute();

Console.ReadLine();