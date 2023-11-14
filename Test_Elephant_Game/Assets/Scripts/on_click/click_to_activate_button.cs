using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click_to_activate_button : MonoBehaviour
{
    public Button button;

    public void OnMouseDown()
    {
        if (button.interactable == false)
            button.interactable = true;
    }
}
