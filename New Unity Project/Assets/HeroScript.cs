using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health;

    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.UpArrow)) ;
            {
                transform.Translate(Vector2.up);
            }
            if (Input.GetKey(KeyCode.DownArrow)) ;
            {
                transform.Translate(Vector2.down);
            }
            if (Input.GetKey(KeyCode.LeftArrow)) ;
            {
                transform.Translate(Vector2.left);
            }
            if (Input.GetKey(KeyCode.RightArrow)) ;
            {
                transform.Translate(Vector2.right);
            }

        }

    }
}
