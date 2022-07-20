using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class NewBehaviourScript : MonoBehaviour
{
    public SpriteAtlas atlas;
    public string atlas_name, resminadi;
    int puan = 0;
    public Text puantext;

    void Start()
    {
        
        PlayerPrefs.DeleteAll();
    }
    public void tıkla()
    {
        puan = PlayerPrefs.GetInt("puan");
        int sayac = PlayerPrefs.GetInt("sayac");
        string spriteIsim = PlayerPrefs.GetString("spriteisim");
        resminadi = PlayerPrefs.GetString("resminadi");

        GetComponent<Image>().sprite = atlas.GetSprite(atlas_name);

        if (spriteIsim !=  atlas_name  && sayac == 0)
        {
            PlayerPrefs.SetString("spriteisim", atlas_name);
            PlayerPrefs.SetInt("sayac", 1);
            PlayerPrefs.SetString("resminadi", GetComponent<Image>().name);
         
        }
        else if (spriteIsim == atlas_name && sayac >= 0 )
        {
            puan++;
            PlayerPrefs.SetInt("puan", puan);
            puantext.text = "" + puan;
            StartCoroutine(wait());
          
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = null;
            GameObject.Find(resminadi).GetComponent<Image>().sprite = null;
            PlayerPrefs.DeleteAll();

        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        Destroy(gameObject);
        Destroy(GameObject.Find(resminadi));
        PlayerPrefs.SetInt("sayac", 0);

    }
}
