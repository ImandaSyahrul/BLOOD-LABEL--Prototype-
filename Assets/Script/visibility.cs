using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visibility : MonoBehaviour
{
    // Start is called before the first frame update
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Show()
    {

        gameObject.SetActive(true);   
    }
}
