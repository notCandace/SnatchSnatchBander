using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickMe : MonoBehaviour
{
    public Button button;

    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        if (button.CompareTag("btn1"))
        {
            prefab.gameObject.SetActive(true);
        }
    } 
}      
