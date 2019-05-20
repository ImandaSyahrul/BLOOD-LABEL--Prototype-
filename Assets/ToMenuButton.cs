using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToMainmenu()
    {
		SceneManager.LoadScene(1);
    }

}
