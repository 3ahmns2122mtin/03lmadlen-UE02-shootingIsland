using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject target;
    public GameObject Snake1;
    public GameObject Snake2;
    public GameObject Snake3;
    public GameObject ParentOfTarget;
    public GameObject objCounter;
    public GameObject WonText;
    public GameObject shootSound;
    public GameObject BGMusic;
    public GameObject Mission1Text;
    //Start-Logo Disapear
    public int secToDestroyLogo;
    public GameObject StartingLogo;

    
  

    private Text textCounter;
    private bool won;
    private int score = 0;
    //Schlangenauswahl
    private int schlangenwahl = 0;
    private const int maxHit= 9;

    // Start is called before the first frame update
    void Start()
    {
        //Background Music
        BGMusic.GetComponent<AudioSource>().Play();
        
        textCounter = objCounter.GetComponent<Text>();
        InvokeRepeating("Spawn",1f,2f);
        won = false;
        WonText.SetActive(false);
        //Schlangenauswahl: Hier habe ich deklariert, das es beim Ersten mal Snake 1 nehmen soll
        target=Snake1;
       



        // Ranom Range Test
        //Debug.Log(Random.Range(4,20));
        //Debug.Log(Random.Range(4,20));
        //Debug.Log(Random.Range(4,20));
        //Debug.Log(Random.Range(4,20));

        //Spawn();

        //Hier habe ich die Start Logo Animation disapearing 5 sekunden deklariert...
        secToDestroyLogo = 5;
        Destroy(StartingLogo,secToDestroyLogo);

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
                    //Debug.Log("MouseDown");
                    shootSound.GetComponent<AudioSource>().Play();
            }
    }

    public void IncrementScore(){
       
        //Das ist das Wos raufzaehlt
        score ++;
        Debug.Log("Increment..." +score);
        textCounter.text = score.ToString();

        //Hier habe ich mit Random Range 1-3 ausgewählt das es eine variable zwischen 1 und 3 nimmt und wenn 1 dann soll es als Target Snake 1 verwenden, wenn 2 Snake 2 und so weiter...
        schlangenwahl = Random.Range(1,3);
        if (schlangenwahl==1){
            target=Snake1;
        }

        if (schlangenwahl==2){
            target=Snake2;
        }

        if (schlangenwahl==3){
            target=Snake3;
        }


        //Maximal Hit
        if (score>maxHit){
            won = true;
             WonText.SetActive(true);
             Destroy(Mission1Text);
        }
    }
}
