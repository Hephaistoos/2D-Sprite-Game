using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class puanarttırma : MonoBehaviour
{
    int puan = 0;
    public Text puantext;
    
    void Start()
    {
        
    }


    public void dogru1()
    {
        puan++;
        puantext.text = "" + puan;

        if (puan == 3)
        {
            SceneManager.LoadScene(0);
            SahneKilit.seviye2 = true;

        }
    }

    public void dogru2()
    {
        puan++;
        puantext.text = "" + puan;

        if (puan == 6)
        {
            SceneManager.LoadScene(0);
            SahneKilit.seviye3 = true;
        }
    }
    public void dogru3()
    {
        puan++;
        puantext.text = "" + puan;
        if (puan == 9)
        {
            SceneManager.LoadScene(0);
        }
    }
       
    
}
