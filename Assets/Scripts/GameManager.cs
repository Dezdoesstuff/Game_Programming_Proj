using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject UI, Intro_room_choice, Titlescreen, /*GameText,*/ Ending1;
    public int health, sanity;
    public TextMeshProUGUI healthText, sanityText;
    // Start is called before the first frame update
    void Start()
    {
        Titlescreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();
        sanityText.text = sanity.ToString();
    }
    
    public void StartGameButton()
    {
        Titlescreen.SetActive(false);
        Intro_room_choice.SetActive(true);
        /*GameText.SetActive(true);
        GameText.text = "You wake up in a dark classroom.";*/
    }
    public void EndGameButton()
    {
        Application.Quit();
    }
    public void Choice_1()
    {
        /*GameText.text = "Where is everyone?";*/
        sanity -= 5;
    }
    public void Choice_2()
    {
        /*GameText.text = "Damn, someone decided to rummage through my things... I only have a lighter in here.";*/
        sanity -= 5;
    }
    public void Choice_3()
    {
        Intro_room_choice.SetActive(false);
        sanity -= 5;
    }
}
