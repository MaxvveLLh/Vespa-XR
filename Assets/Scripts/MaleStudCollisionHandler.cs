using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleStudCollisionHandler : MonoBehaviour
{
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        parent.GetComponent<BrickCollisionHandler>().OnTriggerEnterMaleStud(this.gameObject, collider.gameObject);
    }
    void OnTriggerExit(Collider collider)
    {
        parent.GetComponent<BrickCollisionHandler>().OnTriggerExitMaleStud(this.gameObject, collider.gameObject);
    }
}
