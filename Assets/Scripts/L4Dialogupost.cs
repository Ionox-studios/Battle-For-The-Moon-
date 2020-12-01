using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class L4Dialogupost : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject DialogAsset;

    // Start is called before the first frame update
    void Start()
    {

        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("huff huff huff. IS.THAT.ALL.YOU'VE.GOT./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("I yield to the more powerful./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("Well dang even if the moon is worth a pile o' loot it looks like we ain't gonna be able to rustle it from you./wait:1//close/ ", "Jeff"));


        dialogTexts.Add(new DialogData("Grace, I will trust you, please come back to earth at some point./wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("What is next?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("I guess enough space junk has fallen that I can build a ship and get back to earth, talk them into abandoning this./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("It'll take some time but they'll hear me eventually./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("I could just teleport you./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("THAT WAS AN OPTION?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("I thought it unadvisable while they were still trying to murder you. And before they feared me properly/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Valid./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Please return. I shall give you the ability to teleport back. I know you have your calling but now that I have known you I will miss you./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("You know you can also hang out with other people, just because you are a god doesn't mean you have to be so isolated./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Hmmm. Perhaps I shall, maybe you can talk this Natalia into meeting with me. She seems nice. And maybe others, maybe even Sochi they seem primal I appreciate that./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Haha you would./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("I gotta go now Thoth.... I will miss you and... I... Love... You./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Good bye love./wait:1//close/ ", "Thoth"));





        DialogData LastDialogue = new DialogData("/close/", "Thoth");
        LastDialogue.Callback = () => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        dialogTexts.Add(LastDialogue);
        DialogManager.Show(dialogTexts);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Select"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
