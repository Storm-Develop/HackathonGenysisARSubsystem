
using System.Collections.Generic;

public class KnowledgeBase
{
    public string id { get; set; }
}

public class Faq
{
    public List<object> alternatives { get; set; }
    public string answer { get; set; }
    public string question { get; set; }
}

public class Result
{
    public KnowledgeBase KnowledgeBase { get; set; }
    public List<object> categories { get; set; }
    public double confidence { get; set; }
    public string externalUrl { get; set; }
    public Faq faq { get; set; }
    public string id { get; set; }
    public string languageCode { get; set; }
    public string type { get; set; }
}

public class RootObject
{
    public int pageCount { get; set; }
    public int pageNumber { get; set; }
    public int pageSize { get; set; }
    public string query { get; set; }
    public List<Result> results { get; set; }
    public string searchId { get; set; }
    public int total { get; set; }
}