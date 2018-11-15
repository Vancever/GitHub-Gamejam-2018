using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour
{

    //public BodyPart bodyPart;
    //public int totalParts;

    public float health = 100;

    [Range(1, 10)]
    public int attackValue = 8;

    [Range(1, 10)]
    public int healthBoost = 8;
    public bool safe = true;

    public bool isDead = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            if (!safe)
            {
                health -= (float)attackValue;
            }
            else
            {
                if (health < 100)
                {
                    health += (float)healthBoost;
                }

                if (health < 0)
                {
                    health = 0;
                    isDead = health <= 0 ? true : false;
                }
            }
        }
        else
        {
            OnExplode();
        }
        
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            isDead = health == 0 ? true : false;
            safe = false;
            if (isDead)
            {
                OnExplode();
            }
        }

    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            isDead = health <= 0 ? true : false;
            safe = true;
            if (isDead)
            {
                OnExplode();
            }
        }

    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            isDead = health <= 0 ? true : false;
            safe = false;
            if (isDead)
            {
                OnExplode();
            }
        }
    }

    void OnCollisionExit2D(Collision2D target)
    {
        if (target.gameObject.tag == "Enemy")
        {
            isDead = health <= 0 ? true : false;
            safe = true;
            if (isDead)
            {
                OnExplode();
            }
        }
    }

    public void OnExplode()
    {
        Destroy(gameObject);

        //var t = transform;

        //for (int i = 0; i < totalParts; i++)
        //{
        //    BodyPart clone = Instantiate(bodyPart, t.position, Quaternion.identity) as BodyPart;
        //    clone.rigidbody2D.AddForce(Vector3.right * (Random.Range(-50, 50)));
        //    clone.rigidbody2D.AddForce(Vector3.up * Random.Range(100, 400));
        //}

        //GameObject go = new GameObject("ClickToContinue");
        //ClickToContinue script = go.AddComponent<ClickToContinue>();
        //script.scene = Application.loadedLevelName;
        //go.AddComponent<DisplayRestartText>();

    }

}
