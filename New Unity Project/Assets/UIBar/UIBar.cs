using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIBar : MonoBehaviour {

    public Image bar;
    public GameObject gameOverUI;
    public float barTime = 0.1f;
    public float powerLevel = 0.1f;
    public float amountToAdd = 0.01f;
    
    public enum PowerUpType
    {
        PowerUp,
        PowerDown
    }

public PowerUpType powerUp;

    void OnTriggerEnter () {
        switch (PowerUp)
        {
           case PowerUpType.PowerUp:
                StartCoroutine(PowerUpBar());
           break;
           
           case PowerUpType.PowerDown:
                StartCoroutine(PowerDownBar());
           break;
        }
    }

    IEnumerator PowerUpBar () {
        while (bar.fillAmount < 1)
        {
            bar.fillAmount += amountToAdd;
            yield return new WaitForSeconds(barTime);
        }
    }

    IEnumerator PowerDownBar () {
        float tempAmount = bar.fillAmount - powerLevel;
        if(tempAmount <= 0) {
            tempAmount = 0;
        }

        while (powerLevel > tempAmount)
        {
            bar.fillAmount -= amountToAdd;
            yield return new WaitForSeconds(amountToAdd);

            if (bar.fillAmount == 0){
                yield return null;
            }
        
        if (bar.fillAmount == 0)
        {
            gameOverUI.SetActive(true);
            CharacterController.gameOver = true;
        }
        
        
        }
    }
}