using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public bool chickenOneReturned = false;

    public bool chickenTwoReturned = false;

    public bool chickenThreeReturned = false;

    public GameObject finishText;

    public void checkForVictory()
    {
        if(chickenOneReturned && chickenTwoReturned && chickenThreeReturned)
        {
            finishText.SetActive(true);
        }
    }

    public void chickenOneWasReturned()
    {
        this.chickenOneReturned = true;
        checkForVictory();
    }

    public void chickenTwoWasReturned()
    {
        this.chickenTwoReturned = true;
        checkForVictory();
    }

    public void chickenThreeWasReturned()
    {
        this.chickenThreeReturned = true;
        checkForVictory();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
