using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerManager : MonoBehaviour
{   
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -4.2f)
        {
            Destroy(this.gameObject);
        }
    }
}
