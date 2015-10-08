using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LSObject : MonoBehaviour{
    public int unitySceneIndex;
    public int levelDisplayIndex;
    public string levelName;
    public string levelDescription;

    public Image mainImage;

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
        if (levelDisplayIndex > -1)
        {
            if (levelIndexText != null)
            {
                levelIndexText.text = levelDisplayIndex.ToString();
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
