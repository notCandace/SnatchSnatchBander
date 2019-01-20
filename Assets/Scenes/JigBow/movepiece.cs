using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <para>MonoBehavifour is the base class from which every Unity script derives.</para>
public class movepiece : MonoBehaviour
{
    public Button firstbutton;
    public GameObject preFabulous;

    void Start()
    {
        firstbutton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        transform.position = firstbutton.transform.position;
            Debug.Log("GAHHH");

        preFabulous.gameObject.SetActive(true);
    }
}

