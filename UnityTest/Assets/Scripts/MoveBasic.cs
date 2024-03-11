using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    //Maak 2 variabelen beschikbaar in de inspector
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;
    //Maak een variabele voor je rigidbody
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        transform.position = positionUpdate;
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));
    


}
}
