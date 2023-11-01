class Staff : ISearchable, ILoggable
{
    public int Id { get; set; }
    public string Name { get; set; }

    public bool Contains(string value)
    {
        return Name.Contains(value, StringComparison.InvariantCultureIgnoreCase);
    }

    public override string ToString()
    {
        return $"STAFF: {Name}";
    }

    public void Log()
    {
        Console.WriteLine("EN PERSON LOGGAR!");
    }
}