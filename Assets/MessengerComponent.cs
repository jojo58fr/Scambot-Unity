using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessengerComponent : MonoBehaviour
{
    [Header("Setup Components")]

    #region components
    public TextMeshProUGUI pseudo;
    #endregion

    [Space(10)]

    [Header("Default Values")]
    public string defaultPseudo = "Placeholder Pseudo";

    // Start is called before the first frame update
    void Awake()
    {
        pseudo.text = defaultPseudo;
    }

    public void setPseudo(string pseudo)
    {
        this.pseudo.text = pseudo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
