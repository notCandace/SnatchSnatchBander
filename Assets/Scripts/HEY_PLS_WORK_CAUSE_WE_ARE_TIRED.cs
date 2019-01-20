using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HEY_PLS_WORK_CAUSE_WE_ARE_TIRED : MonoBehaviour
{
    public Text heyNow;
    public Button thisIsWhatDreamsAreMadeOf;
    // Start is called before the first frame update
    void Start()
    {
        heyNow.text = "";
        thisIsWhatDreamsAreMadeOf.interactable = false;
        thisIsWhatDreamsAreMadeOf.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        heyNow.text = "WE'RE TIRED AND YOU'VE REACHED THE END";

    }

    void TaskOnClick()
    {
        thisIsWhatDreamsAreMadeOf.interactable = true;
        SceneManager.LoadScene(0);

    }
}
