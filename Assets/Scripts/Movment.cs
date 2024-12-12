using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    Rigidbody2D RiBo;
    // Start is called before the first frame update
    void Start()
    {
        RiBo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RiBo.velocity = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            RiBo.velocity = new Vector2(7, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RiBo.velocity = new Vector2(-7, 0);

        }
    }
}
