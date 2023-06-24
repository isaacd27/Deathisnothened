using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{

    public float delay = 3f;
    float countdown;

    public float radius = 5f;

    public GameObject ExplosionPart;

    bool hasexploded = false;
    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown >= 0f)
        {
            Explode();
        }
    }

    void Explode()
    {
        if (!hasexploded)
        {
            hasexploded = true;
            Instantiate(ExplosionPart, this.transform);

           // Collider2D[] colliders = new  Physics2D.OverlapCircle(transform.position, radius);
            //foreach(Collider2D Enemy in colliders)
           // {

          //  }
            Destroy(this);
        }
    }
}
