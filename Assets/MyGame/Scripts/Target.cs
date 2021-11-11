using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public int secToDestroy;
    public GameManager gameManager;
    
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        secToDestroy = 2;
        Destroy(gameObject,secToDestroy);

    }


    private void OnMouseDown(){
        //Debug.Log("MouseDown");
        gameManager.IncrementScore();
        Destroy(gameObject);
        
    }

   
}
