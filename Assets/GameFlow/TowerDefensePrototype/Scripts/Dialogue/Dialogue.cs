using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private GameObject dialogueBox;
    [SerializeField,TextArea(4, 6)] private string[] dialogueLines;
    public TextMeshProUGUI dialogueText;

    private float txtSpeed = 0.1f;
    private bool isPlayerInRange;
    private bool didDialogueStarted;
    private int iLine;
    private int pass = 0;
    // Start is called before the first frame update
   // void Start()
    //{
        
   // }
    // Update is called once per frame
    void Update()
    {
       if (isPlayerInRange && pass < dialogueLines.Length)
       {    
            if(!didDialogueStarted){
                StartDialogue();
            }
            //else if (Input.GetMouseButtonDown(0))
            else if (dialogueText.text == dialogueLines[iLine])
            {
                NextText();
                pass++;
            }
            
       } 
    }


    private void StartDialogue()
    {
        didDialogueStarted = true;
        dialogueBox.SetActive(true);
        Debug.Log("entra");
        iLine = 0;
        StartCoroutine(WriteLine());
        //dialogueText.SetActive(true);
    }

    private IEnumerator WriteLine()
    {
         dialogueText.text = string.Empty;
        foreach (char letter in dialogueLines[iLine])
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(txtSpeed);
        }
    }

    public void NextText()
    {
        iLine++;
        if (iLine < dialogueLines.Length)
        {
            StartCoroutine(WriteLine());
            //dialogueText.text = string.Empty;
            
        }
        else
        {
            didDialogueStarted = false;
            isPlayerInRange = false;
            dialogueBox.SetActive(false);
            Debug.Log("end");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            isPlayerInRange = true;
            //dialogueBox.SetActive(true);
            Debug.Log("mensaje");
        
    }
//quitar función cada vez que se aleja va quitar el dialogo, mejor que se quite con click
  /*  private void OnTriggerExit2D(Collider2D collision)
    {
       // if (collision.gameObject.CompareTag("enemy1"))
        //{
        //if (Input.GetButtonDown("Fire1"))
        //{
            isPlayerInRange = false;
            dialogueBox.SetActive(false);
            Debug.Log("NO mensaje");
       // }
    }*/





}

