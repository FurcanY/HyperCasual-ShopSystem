using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    

    private void Awake()
    {
            rb = GetComponent<Rigidbody>();
            this.transform.GetChild(PlayerPrefs.GetInt("select_index")).gameObject.SetActive(true);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(horizontal*speed,0, vertical * speed) *Time.deltaTime);
    }
}
