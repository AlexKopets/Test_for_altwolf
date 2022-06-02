using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAndRun : MonoBehaviour
{
    [SerializeField] private int direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (direction == 0)
        {
            transform.Rotate(0, 0, 50.0f * Time.deltaTime);
        }
    else if (direction == 1)
        {
           transform.Translate(Vector3.right*Time.deltaTime*0.5f, Space.Self);
        }
        
    }

    public void ChangeDirection(int buttonDirection)
    {
        direction = buttonDirection;
    }
}
