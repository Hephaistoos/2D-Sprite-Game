using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SahneKilit : MonoBehaviour
{
    public Button seviye1_button, seviye2_button, seviye3_button, seviye4_button, seviye5_button;
    public static bool seviye1, seviye2, seviye3;
    
    void Start()
    {
        seviye1_button.interactable = true;
        seviye2_button.interactable = false;
        seviye3_button.interactable = false;
        seviye4_button.interactable = false;
        seviye5_button.interactable = false;
    }

   
    void Update()
    {
        if(seviye2 == true)
        {
            seviye2_button.interactable = true;
        }
        if(seviye3 == true)
        {
            seviye3_button.interactable = true;
        }

        }

    public void baslangıc()
    {
        seviye1 = true;
        SceneManager.LoadScene(1);
    }
    public void seviye1bitir()
    {
        seviye2 = true;
        SceneManager.LoadScene(2);
    }
    public void seviye2bitir()
    {
        seviye3 = true;
        SceneManager.LoadScene(3);
    }
 }

