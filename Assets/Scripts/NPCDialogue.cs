using System.Collections;
using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    private bool isPlayerInRange;
    private bool didDialogueStart;
    private int lineIndex;
    private float typingTime = 0.08f;

    private PlayerController player;

    
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueTxt;
    [SerializeField, TextArea(4, 6)] private string[] dialogueLines;
    GameObject inventari;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        inventari = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Fire1"))
        {
            inventari.SetActive(false);
            if (!didDialogueStart)
            {
                StartDialogue();
            }
            else if (dialogueTxt.text == dialogueLines[lineIndex])
            {

                NextDialogueLine();
            }
            else
            {
                StopAllCoroutines();
                dialogueTxt.text = dialogueLines[lineIndex];
            }
        }

      
    }

    private IEnumerator ShowLine()
    {
        dialogueTxt.text = string.Empty;

        foreach(char ch in dialogueLines[lineIndex])
        {
            dialogueTxt.text += ch;
            yield return new WaitForSeconds(typingTime);
        }
    }
    private void StartDialogue()
    {
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        lineIndex = 0;
        StartCoroutine(ShowLine());

    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if(lineIndex< dialogueLines.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("Hola");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("Ha sortit del trigger");
        }
    }
}
