using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2, 2);
        float y = Random.Range(1, 4);
        if (gameObject.name == "Ball (3)" || gameObject.name == "Ball (2)")
        {
            y = Random.Range(-1, 2);
        }
        gameObject.transform.position = new Vector2(x, y);
    }
    private void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
        Destroy(gameObject);
    }
}
