using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target) {
        if(target.gameObject.CompareTag("EndPoint")){
            Debug.Log("Você Venceu!");
            target.gameObject.SetActive(false);
        }
    }
}
