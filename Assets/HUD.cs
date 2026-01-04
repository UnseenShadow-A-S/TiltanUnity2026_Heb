using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public TMP_Text healthText;

 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateHealthText(int health)
    {
        healthText.text = "Health: " + health;
    }
    

}
