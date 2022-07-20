using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    public GameObject taş;
    public GameObject explosion;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();



    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(1f,0f);
            sr.flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-1, 0f);
            sr.flipX = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0f, 1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0f, -1f);
        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (zıplıyormu == false)
            {
                rb.AddForce(Vector2.up * 450f);
                zıplıyormu = true;
            }
        }*/

       /* if(Input.GetAxisRaw("Horizontal") == -1f)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f); 
        }
        else if(Input.GetAxisRaw("Horizontal") == 1f)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }*/  

       // Yukarısı da karateri döndermek için farklı bir yöntem.
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "tas")
        {
            Destroy(collision.gameObject);
            // this.gameObject.SetActive(false); karakteri yok etmenin farklı bir yolu.
            GameObject efekt = Instantiate(explosion) as GameObject;
            efekt.transform.position = transform.position;
            efekt.SetActive(true);
        }
    }
}

