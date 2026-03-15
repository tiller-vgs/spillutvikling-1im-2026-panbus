using UnityEngine;



public class Pandamovement : MonoBehaviour
{
    public Vector3[] feltposisjoner;
    private int PosisjonFeltIndeks = 0;
    public void FlyttPanda(int AntallSkritt)
    {
        //Disse legger sammen posisjonen vi står på og det som terning kastet viser.
        PosisjonFeltIndeks += AntallSkritt; 

        if (PosisjonFeltIndeks >= feltposisjoner.Length)
        {
            PosisjonFeltIndeks = 0;
        }
        //Denne linjen med koden henter felt posisjonene fra 
        transform.position = feltposisjoner[PosisjonFeltIndeks];

    
    }
        void Start()
    {   //Vist du er en person som ikke vet hva dette er. Er dette for deg!! Så jeg tar en transform position i void start fordi jeg vil at pandaen/karakteren min skal alltid start på capetown som er start området. og jeg gjør det på void start fordi jeg vil at det er den første tingen som skjer.
        transform.position = new Vector3 (-2.95f, -3.35f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }


        



    
}
