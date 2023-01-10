using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteAudio : MonoBehaviour
{
    public void MuteToggle(bool Muted)
    {
        if(Muted)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
    }
}
