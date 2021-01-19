using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsClick : MonoBehaviour
{
    public Recording rec;
    public LevelList lvlList;
    public bool restart;
    public SkinsList skin;
    public void startGame()
    {
        SceneManager.LoadScene("DefaultLevel");
    }

    public void nextLevel()
    {
        if (restart)
        {
            SceneManager.LoadScene("DefaultLevel");
        }
        else
        {
            int z = lvlList.Levels.Count;
            if (z > rec.CurrentLevel+1)
            {
                rec.CurrentLevel += 1;
                if (rec.MaxLevel < rec.CurrentLevel)
                {
                    rec.MaxLevel = rec.CurrentLevel;
                }

                if (lvlList.Levels[rec.CurrentLevel].Boss)
                {
                    SceneManager.LoadScene("Boss");
                }
                else
                {
                    SceneManager.LoadScene("DefaultLevel");
                }
            }
            else
            {
                rec.CurrentLevel = 0;
                returnHome();
            }
        }
        PlayerPrefs.SetInt("AppleCount", rec.CountApple);
        PlayerPrefs.SetInt("MaxLevel", rec.MaxLevel);
        PlayerPrefs.SetInt("CurrentLevel", rec.CurrentLevel);
        PlayerPrefs.Save();
    }

    public void returnHome()
    {
        PlayerPrefs.SetInt("AppleCount", rec.CountApple);
        PlayerPrefs.SetInt("MaxLevel", rec.MaxLevel);
        PlayerPrefs.SetInt("CurrentLevel", rec.CurrentLevel);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainMenu");
    }

    public void Skins()
    {
        SceneManager.LoadScene("Skins");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
