using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAdapter : MonoBehaviour
{
    [SerializeField] private EdgeCollider2D[] grounds;
    void Start()
    {
        grounds = GetComponentsInChildren<EdgeCollider2D>();
        float tempTransform = grounds[0].bounds.size.x-0.01f;
        for (int i = 0; i < grounds.Length; i++)
        {
            grounds[i].gameObject.transform.position = new Vector2(tempTransform * i, transform.position.y);
        }
    }


}
