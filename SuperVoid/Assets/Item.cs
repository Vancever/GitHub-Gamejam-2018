public class Item
{
    public string Name { get; set; }
    public string Value { get; set; }
    public float Weight { get; set; }
    public string Description { get; set; }
    public bool isCollectable { get; set; }
    public CategoryType Type { get; set; }

}

public enum CategoryType
{
    Scrap, Water, Food, Other
}
