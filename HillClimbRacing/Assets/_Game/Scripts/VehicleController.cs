using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D backTire,frontTire,myRB;
    public float fuel;
    [SerializeField] private float carTorque,fuelComsumption;
    public float currentSpeed,speed;
    public float movement;
    [HideInInspector] public GameController gameController;
    private void Start() {
        gameController=FindObjectOfType<GameController>();
    }
    private void Update(){
        
        if(fuel > 0){
            if(gameController.gasBtnPressed){
                fuel -= fuelComsumption * (Mathf.Abs(movement)*Time.deltaTime);
                movement = 10 * currentSpeed * Time.deltaTime;
                //movement = Input.GetAxis("Horizontal");
            }else if(gameController.brakeBtnPressed){
                fuel -= fuelComsumption * (Mathf.Abs(movement)*Time.deltaTime);
                movement = 10 * -currentSpeed * Time.deltaTime;
            }
        }
        
        //if(fuel <=0.25 && !gameController.gameover){gameController.fuelWarning.SetActive(true);}
        if (fuel <=0f){
            StartCoroutine(gameController.Gameover());
        }
    }
    private void FixedUpdate() {
        if(fuel>0){
            backTire.AddTorque(-movement*(currentSpeed* Time.fixedDeltaTime));
            frontTire.AddTorque(-movement*(currentSpeed* Time.fixedDeltaTime));
            myRB.AddTorque(-movement*(carTorque* Time.fixedDeltaTime));
        }
    }
}
