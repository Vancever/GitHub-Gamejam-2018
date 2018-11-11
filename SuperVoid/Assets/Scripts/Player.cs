using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed { get; set; }
    private float _size { get; set; }
    private int _weight
    {
        get
        {
            return (this.bag.TotalWeight);
        }
    }

    public int score { get; set; }
    public int healthCount { get; set; }
    public GameObject playerObject { get { return this.gameObject; } }

    public Bag bag;
    public string playerName;

    /// <summary>
    /// Awake runs before Start()
    /// Use as an Init()
    /// Finds all objects tagged "PickupItem" and sets it into an array
    /// </summary>
    private void Awake()
    {
        _speed = 1.5f;

    }


    /// <summary>
    /// Probably wan to to call this from Manager Script, to make it more OOP friendly
    /// </summary>
    private void Update()
    {
        PlayerMovement();
    }

    /// <summary>
    ///
    /// </summary>
    protected void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerObject.transform.position += Vector3.left * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerObject.transform.position += Vector3.right * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerObject.transform.position += Vector3.up * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerObject.transform.position += Vector3.down * _speed * Time.deltaTime;
        }
    }
}
