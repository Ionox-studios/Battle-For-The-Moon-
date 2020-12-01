using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class L3Dialogu : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject DialogAsset;

    // Start is called before the first frame update
    void Start()
    {

        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Will these humans ever stop?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Yea at some point they'll realize this is a waste of money and quit./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("And what will you do after? I guess... I... must send you home then.../wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Well not riiigghhttt away, you can show me the moon first, and I could come back and visit you./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Only if you wanted of course./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("I...ummm.... that... umm.... would... BeRellyNice/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Gracceeeeyyy./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("Oh damn I knew you'd come eventually./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("You gonna introduce me to your friend Gracey?/wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("I swear you leave earth for one month and you go hook up with some space trollop./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("And WHO are YOU?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Oh I'm little Gracey's sibling Sochi./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("Half-sibling./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Do you have a close personal tie to everyone in the space program?/wait:1//close/ ", "Thoth"));
        dialogTexts.Add(new DialogData("It's a small community./wait:1//close/ ", "Grace"));
        dialogTexts.Add(new DialogData("So are you going to get out of my way and let me get the fuel or am I going to have to/wait:1//close/ ", "Sochi"));
        dialogTexts.Add(new DialogData("kick your ass like I have everytime before./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("Look Sochi we can't take the fuel, the processing will destabilize and destroy the moon!/wait:1//close/ ", "Grace"));
        dialogTexts.Add(new DialogData("Wow, you probably should have mentioned that in your funding application to go look/wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("for space fuel, Gracey... shouldn't you have Gracey... or did you lie?/wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("You came here, looking for fuel that you knew would destroy me?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Well I didn't expect to find anything, I was mostly just lying to get funding to fuck around on the moon./wait:1//close/ ", "Grace"));
        dialogTexts.Add(new DialogData("I mean I knew if there was fuel it would destroy the moon but I figured I'd deal with that bridge when I came to it./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("And I've got that on tape so after I kill your moon friend and get my miners landed I'll be sure to send that/wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("to the proper authorities and get you locked up. Today gets better and better./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("Grace I'm a little unhappy with you right now, but I'm much more unhappy with them so we'll talk after/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("I’ll show them what happens to people who insult my... uh... friend...unless./wait:1//close/ ", "Thot"));
        dialogTexts.Add(new DialogData("It's murderin time/wait:1//close/ ", "Sochi"));

        DialogData LastDialogue = new DialogData("/wait:1//close/ ", "Sochi");
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
