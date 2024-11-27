using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    public Slider sliderVolume;
    public GameObject subMenu;
    public Text tTitle;
    public GameObject smcredits;
    public GameObject smsettings;
    
    

    // Start is called before the first frame update
    void Start()
    {
       Volume.Instance.ChangeMusic();
    }

    // Update is called once per frame
    void Update()
    {
        sliderVolume.value = Volume.Instance.asMusic.volume;
    }
    public void SliderVolume()
    {
        Volume.Instance.asMusic.volume = sliderVolume.value;
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
}
