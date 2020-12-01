using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class L3Dialogupos : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject DialogAsset;

    // Start is called before the first frame update
    void Start()
    {

        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("So, how many times did she shoot you?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Three./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Wow that sounds cruel./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Mostly... her... fault... she... kept./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("Starting...bb gun fights... with me.../wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("Not.... my... fault she always lost./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("Beat you this time didn't I?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("You won the battle... not... waaa.../wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("I'm sorry Thoth, I was really irresponsible, I get an idea in my head and get excited/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("and I don't really think about the consequences./wait:1//close/ ", "Grace"));
        dialogTexts.Add(new DialogData("If you hadn't been here I'd.... I'd be dead. So thanks for saving me and all./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("You are the first human I am glad to have saved./wait:1//close/ ", "Thoth"));
        dialogTexts.Add(new DialogData("Your choices were poor but it brought you here and maybe that is.... fffaaaatte?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Once this is all over we'll go get some moon coffee? and see what else is fated to be/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("I mean if you want to I want to./wait:1//close/ ", "Thoth"));





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
