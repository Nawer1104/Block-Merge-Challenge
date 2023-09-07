using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        transform.RotateAround(target.position, new Vector3(0f, 0f, 1f), 90f * Time.deltaTime);
    }

    public void RemoveFromList()
    {
        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].blocks.Remove(this);
        gameObject.SetActive(false);
    }
}
