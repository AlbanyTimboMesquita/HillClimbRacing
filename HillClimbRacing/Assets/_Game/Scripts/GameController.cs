using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [HideInInspector] public GameObject player;
    [SerializeField] private Transform startPoint,endPoint;
    public int currentScore;
    public bool gasBtnPressed,brakeBtnPressed,gameover;
    void Awake()
    {
       player = GameObject.FindGameObjectWithTag("Player"); 
    }

    private void Start() {
        player.transform.position = startPoint.position;
        CalculateDistance();
    }

    void Update()
    {
        
    }
    public float CalculateDistance(){
        return Vector3.Distance(startPoint.position, endPoint.position);
        
    }
    public float CalculatePlayerDistance(){
        return player.transform.position.x - startPoint.position.x;
    }
    public float UpdateFuel(){
        return player.GetComponent<VehicleController>().fuel;
    }
    public IEnumerator Gameover(){
    
        gameover=true;
        
        gasBtnPressed=false;
        brakeBtnPressed=false;
        //fuelWarning.SetActive(false);
        
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
