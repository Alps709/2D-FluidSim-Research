using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health = 100.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
