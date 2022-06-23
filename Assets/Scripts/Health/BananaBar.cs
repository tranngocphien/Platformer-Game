using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BananaBar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Text bananaCount;

    private void Update()
    {
        bananaCount.text = playerHealth.banana + "";
    }

}
