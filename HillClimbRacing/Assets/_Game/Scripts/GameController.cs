using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private Transform startPoint,endPoint;
    public int currentScore;
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
}
