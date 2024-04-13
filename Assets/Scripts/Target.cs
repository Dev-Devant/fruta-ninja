using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour{

    private Rigidbody rb ;
    private GUI guiCanvas;
    public int score = 1;
    void Start()   {
        rb = GetComponent<Rigidbody>();
        rb.AddForce( randomVector(10.0f) ,ForceMode.Impulse);
        rb.AddTorque( randomVector(1.0f) , ForceMode.Impulse);
        guiCanvas = GameObject.Find("Canvas").GetComponent<GUI>();
    }

    void Update()   {

    }

    Vector3 randomVector(float intencidad){        
        float x = Random.Range(-0.5f,0.5f);
        float y = Random.Range(0.8f,1.5f);
        Vector3 output = new Vector3 (x,y,0);
        return output * intencidad;
    }

    void OnMouseDown(){
        guiCanvas.updateScore(score);
        Destroy(gameObject);
    }
}
