using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publisher : MonoBehaviour
{
    public delegate void PublishEvent();
    public static event PublishEvent Publish;

    public void PublishTheEvent()
    {
        if (Publish != null)
        {
            Publish();
        }
    }
    private void OnMouseDown()
    {
        PublishTheEvent();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
