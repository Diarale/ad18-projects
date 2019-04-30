using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;



public class gameplayCanvas : MonoBehaviour
{



    public static gameplayCanvas instance;
    public GameObject directionalLight;
    public monster[] monsters;
    public Text txtPages;
    public Text winText;
    public string pagesString;
    public int pagesTotal = 4;
    private int pagesFound = 0;

    void Awake()
    {
        instance = this;

    }


    // Start is called before the first frame update
    void Start()
    {
        updateCanvas();
    }

    public void updateCanvas()
    {
        pagesString = "Toys " + pagesFound.ToString() + "/" + pagesTotal.ToString();
        txtPages.text = pagesString;


    }

    public void findPage()
    {
        pagesFound++;
        updateCanvas();


        //win
        if (pagesFound >= pagesTotal)
        {
            directionalLight.SetActive(true);


            for (int n = 0; n < monsters.GetLength(0); n++)
            {
                monsters[n].death();
            }

            winText.gameObject.SetActive(true);
        }
    }



}
