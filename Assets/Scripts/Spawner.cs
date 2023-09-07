using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] blockPrefabs;

    int index = 0;

    public Sprite[] sprites;

    private new SpriteRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();

        renderer.sprite = sprites[index];
    }

    public void ChangeColor()
    {
        index += 1;

        if (index > sprites.Length - 1)
        {
            index = 0;
        }

        renderer.sprite = sprites[index];
    }

    private void OnMouseDown()
    {
        Instantiate(blockPrefabs[index], transform.position, transform.rotation);
    }
}
