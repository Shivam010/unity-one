using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerate : MonoBehaviour
{
    private Rigidbody2D com;

    void Start()
    {
        com = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        com.AddForce(Input.acceleration);
    }
    private void OnMouseDrag()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        com.AddForce(Vector2.MoveTowards(this.transform.position, worldPosition, 8 * Time.deltaTime));
        //this.transform.position = Vector2.MoveTowards(this.transform.position, worldPosition, 8*Time.deltaTime);
    }


}
