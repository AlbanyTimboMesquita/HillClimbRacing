using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D backTire,frontTire,myRB;
    [SerializeField] private float fuel;
    [SerializeField] private float speed,carTorque,fuelComsumption;
    private float movement;
    
    private void Update(){
        if(fuel > 0){
            fuel -= fuelComsumption * (Mathf.Abs(movement)*Time.deltaTime);
            movement = Input.GetAxis("Horizontal");
        }
    }
    private void FixedUpdate() {
        if(fuel>0){
            backTire.AddTorque(-movement*(speed* Time.fixedDeltaTime));
            frontTire.AddTorque(-movement*(speed* Time.fixedDeltaTime));
            myRB.AddTorque(-movement*(carTorque* Time.fixedDeltaTime));
        }
    }
}
