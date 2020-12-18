using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FriendComponent : MonoBehaviour
{
    [Header("Setup Components")]
    
    #region components
    public Image statusBar;
    public TextMeshProUGUI pseudo;
    public Image avatar;
    #endregion

    [Space(10)]

    [Header("Default Values")]
    public Color busyColor = Color.red;
    public Color availableColor = Color.green;
    public string defaultPseudo = "Placeholder Pseudo";
    public Sprite defaultSprite;

    // Start is called before the first frame update
    void Awake()
    {
        pseudo.text = defaultPseudo;
        avatar.sprite = defaultSprite;
        statusBar.color = busyColor;
    }

    public void setPseudo(string pseudo)
    {
        this.pseudo.text = pseudo;
    }

    public void setProfil(Sprite sprite)
    {
        avatar.sprite = defaultSprite;
    }

    public void setBusy()
    {
        statusBar.color = busyColor;
    }

    public void setAvailable()
    {
        statusBar.color = availableColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
