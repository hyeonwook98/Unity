using System.Collections;
using UnityEngine;

public class RouletteController : MonoBehaviour{
    float rotSpeed = 0; //ȸ�� �ӵ�
    
    void Start(){   
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            this.rotSpeed = 5000
                
                ;
        }

        //ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��.
        transform.Rotate(0, 0, this.rotSpeed);

        //�귿�� ���ӽ�Ų��.(�߰�)
        this.rotSpeed *= 0.96f;
    }
}

