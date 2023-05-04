using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusBotController : MonoBehaviour
{
     float speedBus = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedBus);
    }
}
