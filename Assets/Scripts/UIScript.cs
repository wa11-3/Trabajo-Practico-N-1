using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TMP_Text grettings;

    public void ShowGrettings(string textShow)
    {
        grettings.text = textShow;
    }
}
