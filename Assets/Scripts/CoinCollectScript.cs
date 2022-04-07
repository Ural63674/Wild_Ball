using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollectScript : MonoBehaviour
{
    public Text coinPanelText;
    public Text coinVictoryPanelText;
    public int coinsCollect;

    // Update is called once per frame
    void Update()
    {
        coinPanelText.text = coinsCollect.ToString();
        coinVictoryPanelText.text = coinsCollect.ToString();
    }
}
