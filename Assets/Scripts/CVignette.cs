using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CVignette : MonoBehaviour
{
    public PostProcessVolume volumenEfectos;
    Vignette Vignette;
    // Start is called before the first frame update
    void Start()
    {
        volumenEfectos.profile.TryGetSettings(out Vignette);
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            CambiarIntensidadVignette(0.1f);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            CambiarIntensidadVignette(0.3f);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            CambiarIntensidadVignette(0.6f);
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)){
            CambiarIntensidadVignette(1f);
        }
    }
    public void CambiarIntensidadVignette(float nuevaIntensidad){
        Vignette.intensity.overrideState = true;
        Vignette.intensity.value = nuevaIntensidad;
    }
}


