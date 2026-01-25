using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public TMP_Text healthText;
    public Slider healthBar;
    
    public Image soulsImage;
    
    public int souls = 5;

    private float SoulsImageWidth = 150.0f;

    private void Awake()
    {
        UpdateSouls(souls);
    }

    public void UpdateHealthText(int health)
    {
        healthText.text = "Health: " + health;
    }

    public void UpdateSouls(int soulsAmount)
    {
        float x = SoulsImageWidth * soulsAmount;
        float y = soulsImage.rectTransform.sizeDelta.y;
        
        soulsImage.rectTransform.sizeDelta = new Vector2(x, y);
    }



    public void UpdateHealthBar(int amount, int maxValue)
    {
        float percentage = amount / (float)maxValue;
        healthBar.value += percentage;
        healthBar.value = Mathf.Clamp(healthBar.value, 0, 1);
    } 
}
