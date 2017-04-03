using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
    /* *Note: 0 = Main Menu Canvas
              1 = Continue Canvas
              2 = Options Canvas
              3 = Controls Canvas
              4 = Graphics Canvas
              5 = Audio Canvas
              6 = Quit Confirm Canvas 
    */
    public GameObject[] canvas; 

	void Start ()
    {
        // Set the main menu canvas active
        canvas[0].SetActive(true);

        // Set all other canvas's inactive
        for (int i = 1; i < canvas.Length; i++)
        {
            canvas[i].SetActive(false);
        }
	}

    public void ContinuePressed()
    {
        // Set all canvas's inactive
        for (int i = 0; i < canvas.Length; i++)
            canvas[i].SetActive(false);
        // Reactivate Continue Canvas
        canvas[1].SetActive(true);
    }

    public void OptionsPressed()
    {
        // Set all canvas's inactive
        for (int i = 0; i < canvas.Length; i++)
            canvas[i].SetActive(false);
        // Reactivate Options Canvas
        canvas[2].SetActive(true);
    }

    public void ControlsPressed()
    {
        // Set all canvas's inactive
        for (int i = 0; i < canvas.Length; i++)
            canvas[i].SetActive(false);
        // Reactivate Controls Canvas
        canvas[3].SetActive(true);
    }

    public void GraphicsPressed()
    {
        // Set all canvas's inactive
        for (int i = 0; i < canvas.Length; i++)
            canvas[i].SetActive(false);
        // Reactivate Graphics Canvas
        canvas[4].SetActive(true);
    }

    public void AudioCanvas()
    {
        // Set all canvas's inactive
        for (int i = 0; i < canvas.Length; i++)
            canvas[i].SetActive(false);
        // Reactivate Audio Canvas
        canvas[5].SetActive(true);
    }

    public void QuitConfirm()
    {
        // Set all canvas's inactive
        for (int i = 0; i < canvas.Length; i++)
            canvas[i].SetActive(false);
        // Reactivate Quit Confirm Canvas
        canvas[6].SetActive(true);
    }

    public void BackMainMenu()
    {
        // Set all canvas's inactive
        for (int i = 0; i < canvas.Length; i++)
            canvas[i].SetActive(false);
        // Reactivate Main Menu Canvas
        canvas[0].SetActive(true);
    }

    public void BackToOptions()
    {
        // Set all canvas's inactive
        for (int i = 0; i < canvas.Length; i++)
            canvas[i].SetActive(false);
        // Reactivate Options Canvas
        canvas[2].SetActive(true);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void YesQuit()
    {
        Application.Quit();
    }
}
