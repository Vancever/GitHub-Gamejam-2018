using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{

    public float speed = .5f;
    public Rigidbody2D rgBody;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rgBody.velocity = new Vector2(transform.localScale.x, 0) * speed;
    }
}
