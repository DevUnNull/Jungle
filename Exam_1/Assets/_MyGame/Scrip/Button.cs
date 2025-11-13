using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonn : MonoBehaviour
{
    internal object onClick;

    public void ButtonSound()
    {
        _AudioManager.Instance.PlaySoundEffectMusic(_AudioManager.Instance.jumAudio);
    }
}
