using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LoadSettingsData : MonoBehaviour
{
    public Slider sensitivity; 

    public void LoadData(Data data)
    {
        sensitivity.value = data.sensitivity; 
    }
}
