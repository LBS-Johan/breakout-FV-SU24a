using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.one.normalized * speed;
    }

    void Update()
    {
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);

            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}