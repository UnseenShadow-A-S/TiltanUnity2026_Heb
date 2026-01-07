using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public TMP_Text healthText;

    public void UpdateHealthText(int health)
    {
        healthText.text = "Health: " + health;
    }
    

}
