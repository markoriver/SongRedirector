public class Link {
    public string DisplayName {get;}

    public string Uri {get;}

    public Link(string displayName, string uri)
    {
        DisplayName = displayName;
        Uri = uri;
    }
}