using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cambiaText : MonoBehaviour
{
    public int countMeDown = 0;

    public Text instructAndWin;

    public Button restart;

    private void Start()
    {
        restart.gameObject.SetActive(false);
        restart.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            countMeDown++;
        }

        if (countMeDown == 25)
        {
            instructAndWin.text = "Congratulations, you solved the puzzle";
            restart.gameObject.SetActive(true);
        }
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("heaven");
    }
}
