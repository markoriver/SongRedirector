using System;

public class StaticLinkProvider : ILinkProvider
{

    private static Random rnd = new Random();

    private Link[] links = new[] {
        new Link("Spongebob", "https://www.youtube.com/watch?v=r9L4AseD-aA"),
        new Link("Eskalation", "https://www.youtube.com/watch?v=J10LaIqHj2s"),
        new Link("My Little Pony", "https://www.youtube.com/watch?v=GHy0xktlsSI"),
        new Link("Eternity Frog", "https://soundcloud.com/eternityfrog/her-face-1/s-kGyZs"),
        new Link("Bob Marley", "https://www.youtube.com/watch?v=X2W3aG8uizA"),
        new Link("Tool Time", "https://www.youtube.com/watch?v=Ejz_1qoE7hc"),
        new Link("Chitlins, Whiskey and Skirt", "https://www.youtube.com/watch?v=uny-UwwtD3c"),
    };

    public string GetLink()
    {
        var idx = rnd.Next(links.Length);
        return links[idx].Uri;
    }
}
