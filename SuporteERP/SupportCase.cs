public class SupportCase
{
    public int Id { get; set; }
    public string Problem { get; set; }
    public string Solution { get; set; }
    public List<string> ImagensBase64 { get; set; } = new();
}
public class SupportCaseML
{
    public string Problem { get; set; }
    public string Solution { get; set; }
}


public class SupportCaseTfidf
{
    public string Problem { get; set; }
    public float[] Features { get; set; }
}