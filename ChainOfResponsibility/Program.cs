using ChainOfResponsibility.Middlewares;
using ChainOfResponsibility.Servers;

internal class Program
{
    private static Server server;
    static void Init()
    {
        server = new Server();
        server.RegisterUser("caue@master.com.br", "123456");
        server.RegisterUser("caue@tester.com.br", "123456");

        Middleware middleware = new CheckUserMiddleware(server);
        middleware.LinkWith(new CheckPermissionMiddleware());

        server.SetMiddleware(middleware);
    }

    private static void Main(string[] args)
    {
        Init();

        Boolean done = false;

        do
        {
            Console.WriteLine("Digite seu email");
            string email = Console.ReadLine();
            Console.WriteLine("Digite seu senha");
            string password = Console.ReadLine();

            done = server.Login(email, password);
        } while (!done);

        Console.ReadLine();
    }
}