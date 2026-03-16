using UnityEngine;


public class Terningscript : MonoBehaviour
{
    public Pandamovement pandaen;
    void Start()
    {
    
    }


    void Update()
    {
        //Denne gjør at når Space knappen er trykket så vil terningen rull 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
           

    }
    // dette ruller terningen
            void RollDice()
        {
           int resultat = Random.Range(1,7);
        
        //debug er sånn at man ser hva man ruller, ned i terminalen til unity.
           Debug.Log("Du fikk " + resultat + " Bra jobbet");
        if ( pandaen != null)
        {
            pandaen.FlyttPanda(resultat);
        }
    }
}