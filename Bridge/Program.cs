using Bridge.Platforms;
using Bridge.Transmissions;

static void StartLive(IPlatform platform)
{
    Console.WriteLine("Aguarde...");

    Live live = new Live(platform);

    live.Broadcasting();
    live.Result();
}

static void StartLiveAdvanced(IPlatform platform)
{
    Console.WriteLine("Aguarde...");

    AdvancedLive live = new AdvancedLive(platform);

    live.Broadcasting();
    live.Subtitles();
    live.Comments();
    live.Result();
}

StartLiveAdvanced(new Youtube());
StartLive(new Facebook());
StartLive(new Twitch());

Console.ReadLine();