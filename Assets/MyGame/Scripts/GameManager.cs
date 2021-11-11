using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject ParentOfTarget;
    public GameObject objCounter;

    private Text textCounter;
    public bool won;
    public int score = 0;
  

    // Start is called before the first frame update
    void Start()
    {
        textCounter = objCounter.GetComponent<Text>();
        InvokeRepeating("Spawn",1f,2f);
        won = false;

        
        // Ranom Range Test
        //Debug.Log(Random.Range(4,20));
        //Debug.Log(Random.Range(4,20));
        //Debug.Log(Random.Range(4,20));
        //Debug.Log(Random.Range(4,20));

        //Spawn();
    }

    // Spawn a target at a random Position within a specified x and y range
    // instantiate  (make a concrete GameObjekt i.e., a clone from the given Pprefab target) the target as child
    // target as child of the ParentOfTargets. In this case transform.localPosition instead of transform.position is important!!
    private void Spawn()
    {
        float randomX = Random.Range(-400,400);
        float randomY = Random.Range(-250,250);

        Vector2 random2DPosition = new Vector2(randomX,randomY);

        GameObject myTarget = Instantiate(target,ParentOfTarget.transform);
        myTarget.transform.localPosition = random2DPosition;


        Debug.Log(random2DPosition);
    }
    void Update(){
            if(won ==true){
                CancelInvoke("Spawn");

            }

            if(Input.GetMouseButtonDown(0)){
                    Debug.Log("MouseDown");
            }
    }

    public void IncrementScore(){
        score ++;
        Debug.Log("Increment..." +score);
        textCounter.text = score.ToString();
        if (score>20){
            won = true;
        }
    }
}
