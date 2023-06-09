using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountSummon : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    [SerializeField] GameObject gameObject2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
        gameObject.SetActive(true);
        gameObject2.SetActive(false);
        }
         if (Input.GetKeyDown(KeyCode.N))
        {
        gameObject.SetActive(false);
        gameObject2.SetActive(true);
        }
    }
}
