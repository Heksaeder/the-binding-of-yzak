using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StorylineSO", menuName = "Storyline")]

public class StorylineSO : ScriptableObject
{
    [TextArea(2,5)]
    [SerializeField]
    private string text;
    [SerializeField] private string charName;

    public string Text {
        get {
            return text;
        }
    }

    public string CharName {
        get {
            return charName;
        }
    }
}
