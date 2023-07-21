using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UI, Level1, Level2, Level3, Level4, Level4A, Level4B, Level5, Level6,
        Level7, Level8, Level9, end2, end3, end4, TitleScreen;
    public int health, stamina;
    public TextMeshProUGUI healthText, staminaText;
    // Start is called before the first frame update
    void Start()
    {
        TitleScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = health.ToString();
        staminaText.text = health.ToString();
    }

    public void StartGameButton()
    {
        TitleScreen.SetActive(false);
        Level1.SetActive(true);
    }
    public void Button_1()
    {
        Level1.SetActive(false);
        Level2.SetActive(true);
        //health -= 5;
        //stamina -= 5;
    }
    public void Button_2()
    {
        Level2.SetActive(false);
        Level3.SetActive(true);
        //health -= 5;
        //stamina -= 5;
    }
    public void Button_L3_1()
    {
        Level3.SetActive(false);
        Level4.SetActive(true);
        //health -= 5;
        stamina -= 1;
    }
    public void Button_L4Next()
    {
        Level4.SetActive(false);
        Level4A.SetActive(true);
        //health -= 5;
        //stamina -= 1;
    }

    public void Button_L3_2Next()
    {
        Level3.SetActive(false);
        Level4B.SetActive(true);
        //health -= 5;
        //stamina -= 1;
    }
    public void Button_L4BNext()
    {
        Level4B.SetActive(false);
        Level5.SetActive(true);
        //health -= 5;
        //stamina -= 1;
    }
    public void Button_L5Next()
    {
        Level5.SetActive(false);
        Level6.SetActive(true);
        //health -= 5;
        //stamina -= 1;
    }

    public void Button_L6Next()
    {
        Level6.SetActive(false);
        Level7.SetActive(true);
        //health -= 5;
        //stamina -= 1;
    }
    public void Button_L7Next()
    {
        Level7.SetActive(false);
        Level8.SetActive(true);
        //health -= 5;
        //stamina -= 1;
    }
    public void Button_L8Next()
    {
        Level8.SetActive(false);
        Level9.SetActive(true);
        //health -= 5;
        //stamina -= 1;
    }
    public void Button_end2Next()
    {
        Level9.SetActive(false);
        end2.SetActive(true);
    }

    public void Button_end3Next()
    {
        Level9.SetActive(false);
        end3.SetActive(true);
    }
    public void Button_end4Next()
    {
        Level9.SetActive(false);
        end4.SetActive(true);
    }

}
