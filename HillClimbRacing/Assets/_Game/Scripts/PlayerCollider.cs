using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target) {
        if(target.gameObject.CompareTag("EndPoint")){
            Debug.Log("Você Venceu!");
            target.gameObject.SetActive(false);
        }else if(target.gameObject.CompareTag("Coin")){
            FindObjectOfType<GameController>().currentScore+=target.GetComponent<Coin>().value;
            FindObjectOfType<UIController>().txtCoins.text=FindObjectOfType<GameController>().currentScore.ToString();
            FindObjectOfType<SoundController>().PlaySound(FindObjectOfType<SoundController>().coinAudioSource);
            //Debug.Log(target.GetComponent<Coin>().value);
            //target.gameObject.SetActive(false);
            target.GetComponent<Animator>().SetTrigger("Collected");
            Destroy(target.gameObject,5);
        }else if(target.gameObject.CompareTag("Fuel")){
            this.gameObject.transform.parent.GetComponent<VehicleController>().fuel=target.GetComponent<Fuel>().value;
            //target.gameObject.SetActive(false);
            target.GetComponent<Animator>().SetTrigger("Collected");
            Destroy(target.gameObject,5);
        }
    }
}
