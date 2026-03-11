using UnityEngine;



public class Pandamovement : MonoBehaviour
{
    public Vector3[] feltposisjoner;
        void Start()
    {   //Vist du er en person som ikke vet hva dette er. Er dette for deg!! Så jeg tar en transform position i void start fordi jeg vil at pandaen/karakteren min skal alltid start på capetown som er start området. og jeg gjør det på void start fordi jeg vil at det er den første tingen som skjer.
        transform.position = new Vector3 (-2.95f, -3.35f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }


        public void FlyttPanda(int resultat)
        {   
        if(resultat == 1)
        {
            transform.position = new Vector3 ( -2.91f, -3.32f, 0f);
        }
        else if (resultat == 2)
        {
            transform.position = new Vector3 ( -2.81f, -2.68f, 0f);
        }
        else if (resultat == 3)
        {
            transform.position = new Vector3 ( -3.27f, -2.12f, 0f);
        }
        else if (resultat == 4)
        {
            transform.position = new Vector3 ( -2.58f, -1.76f, 0f);
        }
        else if (resultat == 5  )
        {
            transform.position = new Vector3 ( -1.43f, -1.37f, 0f);
        }
        else if (resultat == 6  )
        {
            transform.position = new Vector3 ( -2.46f, -1.08f, 0f);
        }



    }
}
