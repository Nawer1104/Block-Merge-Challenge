using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockToFire : MonoBehaviour
{
    public float speed = 10f;

    public Rigidbody2D rb;

    public GameObject vfx;

    private void Update()
    {
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject vfxExplosin = Instantiate(vfx, transform.position, Quaternion.identity);
        Destroy(vfxExplosin, 0.75f);

        if (collision.tag == gameObject.tag)
        {
            collision.GetComponent<Block>().RemoveFromList();
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
