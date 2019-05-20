using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePanel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void showPanel()
    {
        gameObject.SetActive(true);
    }

    public void hidePanel()
    {
        gameObject.SetActive(false);
    }
}
