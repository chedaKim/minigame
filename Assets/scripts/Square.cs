using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float y = Random.Range(4.0f, 5.0f);

        transform.position = new Vector3(x, y, 0);

        float size = Random.Range(0.5f, 1.0f);
        transform.localScale = new Vector3(size, size, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.0f) 
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "circle")
        {
            gamemanager.I.gameover();
        }
    }
}
