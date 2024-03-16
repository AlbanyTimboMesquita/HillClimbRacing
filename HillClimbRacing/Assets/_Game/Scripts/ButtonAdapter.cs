using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAdapter : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    private GameController gameController;
    private void Awake() {
        gameController=FindObjectOfType<GameController>();
    }
    public void OnPointerDown(PointerEventData eventData){
        if(this.gameObject.tag=="Gas"){
            gameController.gasBtnPressed=true;
            gameController.brakeBtnPressed=false;
            gameController.player.GetComponent<VehicleController>().currentSpeed=gameController.player.GetComponent<VehicleController>().speed;
        }else if(this.gameObject.tag=="Brake"){
            gameController.brakeBtnPressed=true;
            gameController.gasBtnPressed=false;
            gameController.player.GetComponent<VehicleController>().currentSpeed=-gameController.player.GetComponent<VehicleController>().speed;
        }
    }
    public void OnPointerUp(PointerEventData eventData){
            gameController.brakeBtnPressed=false;
            gameController.gasBtnPressed=false;
            gameController.player.GetComponent<VehicleController>().currentSpeed=0f;
    }
}
