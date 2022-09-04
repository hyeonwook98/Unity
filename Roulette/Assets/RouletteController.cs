using System.Collections;
using UnityEngine;

public class RouletteController : MonoBehaviour{
    float rotSpeed = 0; //회전 속도
    
    void Start(){   
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            this.rotSpeed = 5000
                
                ;
        }

        //회전 속도만큼 룰렛을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);

        //룰렛을 감속시킨다.(추가)
        this.rotSpeed *= 0.96f;
    }
}

