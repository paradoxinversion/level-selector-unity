using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LSObject : MonoBehaviour{
    public int unitySceneIndex;
    public string levelDisplayIndex;
    public string levelName;
    public string levelDescription;

    public Image levelImageHolder;
    public Sprite levelSprite;

    public Text levelNameText;
    public Text levelIndexText;
    public Text levelDescriptionText;

    public void SetText()
    {
        if (!string.IsNullOrEmpty(levelName))
        {
            if (levelName != null)
            { levelNameText.text = levelName; }
            
        }
        if (!string.IsNullOrEmpty(levelDescription))
        {
            if (levelDescriptionText != null)
            {
                levelDescriptionText.text = levelDescription;
            }
        }
        if (!string.IsNullOrEmpty(levelDisplayIndex))
        {
            if (levelIndexText != null)
            {
                levelIndexText.text = levelDisplayIndex.ToString();
            }
        }
        if (levelSprite != null)
        {
            if (levelImageHolder != null)
            {
                levelImageHolder.sprite = levelSprite;
            }
        }
    }

    public void LoadLevel()
    {
        Application.LoadLevel(unitySceneIndex);
    }
    void Start()
    {
        SetText();
    }
}
