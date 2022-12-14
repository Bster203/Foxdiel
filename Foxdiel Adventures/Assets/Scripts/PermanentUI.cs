using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PermanentUI : MonoBehaviour
{
    public int cherries = 0;
    public int health = 5;
    public TextMeshProUGUI cherryText;
    public Text healthAmount;

    public static PermanentUI perm;

    private void Start()
    {
        //Add to Don't Destroy on Load
        DontDestroyOnLoad(gameObject);

        //Set CherryCount
        cherryText.text = cherries.ToString();

        //Singleton
        if(!perm)
        {
            perm = this;
        }
        else
            Destroy(gameObject);
    }

    public void Reset()
    {
        cherries = 0;
        cherryText.text = cherries.ToString();
    }
}
