using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ocubeBehavior : MonoBehaviour
{
    public float moveSpeed;

    void Start()
    {
        moveSpeed = 1f;
    }

    void Update()
    {
        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Time.deltaTime);

        if ((transform != null) && Input.GetKey("left"))
        {
            transform.Rotate(0, (float).5, 0);
        }
        if ((transform != null) && Input.GetKey("right"))
        {
            transform.Rotate(0, (float)-.5, 0);
        }
    }
    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("collidingObject"))
        {
            SceneManager.LoadScene("game_scene");
        }
    }
}
