using UnityEngine;


public class Terningscript : MonoBehaviour
{
    public Pandamovement pandaen;
    void Start()
    {
    
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
           

    }
    // dette ruller terningen
            void RollDice()
        {
           int resultat = Random.Range(1,7);
        
        //debug er sånn at man ser hva man ruller
           Debug.Log("Du fikk " + resultat + " Bra jobbet");
        if ( pandaen != null)
        {
            pandaen.FlyttPanda(resultat);
        }
    }
}