using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Dialogue system for in-game talk
 */
public class DialogueSystem : MonoBehaviour
{
    [HideInInspector] public string NpcName;
    [HideInInspector] public List<string> DialogueLines = new List<string>();
    public static DialogueSystem Instance { get; private set; }
    public GameObject DialoguePanel;
    
    private Button _continueButton;
    private Text _dialogueText, _nameText;
    private int _dialogueIndex;

    private void Awake()
    {
        _continueButton = DialoguePanel.transform.Find("Continue").GetComponent<Button>();
        _dialogueText = DialoguePanel.transform.Find("Text").GetComponent<Text>();
        _nameText = DialoguePanel.transform.Find("Speaker").GetChild(0).GetComponent<Text>();
        _continueButton.onClick.AddListener(ContinueDialogue);

        DialoguePanel.SetActive(false);

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddNewDialogue(string[] lines, string npcName)
    {
        _dialogueIndex = 0;
        NpcName = npcName;
        DialogueLines = new List<string>(lines.Length);
        DialogueLines.AddRange(lines);

        CreateDialogue();
    }

    private void CreateDialogue()
    {
        _dialogueText.text = DialogueLines[_dialogueIndex];
        _nameText.text = NpcName;
        DialoguePanel.SetActive(true);
    }

    private void ContinueDialogue()
    {
        if (_dialogueIndex < DialogueLines.Count - 1)
        {
            _dialogueIndex++;
            _dialogueText.text = DialogueLines[_dialogueIndex];
        }
        else
        {
            DialoguePanel.SetActive(false);
        }
    }
}