using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ActiveWords : MonoBehaviour
{
    public int counter = 0;
    public bool timer = false;
    public GameObject tutorial1;
    public GameObject tutorial2;
    //Collider m_Collider;

    //tutorial1 first sentence of the tutorial
    //tutorial2 second sentence of the tutorial


    //theObject.gameobject.SetActive(true);
    // Use this for initialization

    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        tutorial1.gameObject.SetActive(false);
        tutorial2.gameObject.SetActive(false);
    }

    // Update is called once per frame

    void Update()
    {  //timer becomes true so i can inc the counter

        if (timer == true)
        {
            counter++;
        }

        if (counter == 50)
        {
            tutorial1.gameObject.SetActive(true);//goes to the function active sentence
        }

        if (counter >= 300)
        {

            tutorial1.gameObject.SetActive(false);
            tutorial2.gameObject.SetActive(true); //goes to the function active sentence 2

        }

        if (counter == 600)
            resetTimer();


    }


    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 20, 90, 50), "Press Here"))
        { 
            timer = true;//now that the timer is set a true once you click it,The uptade should see that its true and start the counter then the counter once it reaches 3 it goes to the MoveHero function      
        }
    }

    void resetTimer()
    {  //Set the trigger at true so the gameobject can move to the right,the timer is at false and then the counter is reseted at 0.
        tutorial1.gameObject.SetActive(false);
        tutorial2.gameObject.SetActive(false);
        timer = false;
        counter = 0;
    }
}

