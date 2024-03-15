using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target) {
        if(target.gameObject.CompareTag("Ground")){
            Debug.Log("Você Perdeu!");
        }
    }
}
