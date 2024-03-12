using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Eggbroken;
    void Start()
    {

    }
    

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("dat"))
            {
            Instantiate(Eggbroken, transform.position, Quaternion.identity);
            Destroy(this);
        }
        if (col.gameObject.name.Equals("Box"))
        {
            Destroy(this);
        }
    }
}
