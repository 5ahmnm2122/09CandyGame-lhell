using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float moveSpeed = 1500f;
    // Start is called before the first frame update

    private void Awake() 
    {
        playerRb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerRb != null)
        {
            ApplyInput();
        }
        else
        {
            Debug.LogWarning("No Rigidbody on the Player" + gameObject.name);
        }
    }

    public void ApplyInput()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float xForce = xInput * moveSpeed * Time.deltaTime;

        Vector2 force = new Vector2(xForce, 0);

        playerRb.AddForce(force);

        Debug.Log("xForce = " +  xForce);
    }
    
}
