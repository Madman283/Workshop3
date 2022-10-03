using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSubscriber : MonoBehaviour
{
    Light light;
    private void OnEnable()
    {
        Publisher.Publish += SwitchLight;
    }

    private void OnDisable()
    {
        Publisher.Publish -= SwitchLight;
    }


    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    void SwitchLight()
    {
        light.enabled = !light.enabled;
    }

   
}
