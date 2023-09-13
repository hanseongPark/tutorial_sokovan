using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    private Renderer myRenderer;

    public bool isOveraped = false;

    public Color touchColor;
    public Color originalColor;

    // Start is called before the first frame update
    void Start()
    {
        this.myRenderer = GetComponent<Renderer>();
        this.originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint")
        {
            myRenderer.material.color = touchColor;
            isOveraped = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            myRenderer.material.color = touchColor;
            isOveraped = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            myRenderer.material.color = originalColor;
            isOveraped = false;
        }
    }
}
