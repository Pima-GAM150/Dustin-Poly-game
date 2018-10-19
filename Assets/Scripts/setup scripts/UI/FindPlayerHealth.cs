using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindPlayerHealth : MonoBehaviour {

    public Text HealthText;
    Player player;

    private void Update()
    {
        player = FindObjectOfType<Player>();
        HealthText.text = player.Health.ToString();
    }
}
