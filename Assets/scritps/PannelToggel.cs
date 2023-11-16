using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelToggel : MonoBehaviour
{
    bool isOn = false;
    [SerializeField] GameObject InfoPanel;
    public void onToggle()
    {
        if(isOn)
        {
            InfoPanel.SetActive(false);
            isOn=false;
        }
        else
        {
            InfoPanel.SetActive(true);
            isOn=true;
        }
    }
}
