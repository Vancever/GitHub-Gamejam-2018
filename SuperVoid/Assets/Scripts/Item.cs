using UnityEngine;

public class Item : MonoBehaviour
{
    public string _name;
    public float _weight;
    public string _description;
    public bool _isCollectable;
    public ItemType _type;

    public string Name { get; set; }
    public float Weight { get; set; }
    public string Description { get; set; }
    public bool IsCollectable { get; set; }
    public ItemType Type { get; set; }

}

public enum ItemType
{
    Scrap, Water, Food, Fuel, Other
}
