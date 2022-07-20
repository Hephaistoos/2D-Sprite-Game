using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TasHareket : MonoBehaviour
{
    Vector2 konum;
    public GameObject explosion;
 
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        explosion.transform.position = transform.position;
        GameObject patlatma = Instantiate(explosion) as GameObject;
        Destroy(collision.gameObject);
        this.gameObject.SetActive(false);
        explosion.SetActive(true);

    }
}
