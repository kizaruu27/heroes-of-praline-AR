using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacter : MonoBehaviour
{
    public GameObject[] characters;
    [SerializeField] private int charIndex;

    public void OnClickSwitchCharacter()
    {
        characters[charIndex].SetActive(false);
        charIndex = (charIndex + 1) % characters.Length;
        characters[charIndex].SetActive(true);
    }
}
