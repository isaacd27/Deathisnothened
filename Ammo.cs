using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [Tooltip("0 for pistol, 1 for rifle, 4 for grenades.")]
    public int type;
    public int amount;
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (touched)
        {
            Destroy(this.gameObject);
        }
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // temp = collision.gameObject.GetComponent<Zombie>();
        // Destroy(this.gameObject);
        if (collision.gameObject.CompareTag("Player"))
        {
            
                
            

        }
        // if (temp != null)
        // {

        //}
    }

  
}
