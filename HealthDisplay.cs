using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Player player;
    Text healthText;

    void Start()
    {
        healthText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        healthText.text = player.GetHealth().ToString();
    }
}
