using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnersPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -3.5f || transform.position.y > 4.0f || transform.position.x < -10.0f || transform.position.x > 11)
        {
            SceneManager.LoadScene("WinningScene");
        }
    }
}
