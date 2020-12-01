using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class L1Dialogu : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject DialogAsset;

    // Start is called before the first frame update
    void Start()
    {

        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("Ugh what happened, I feel like shit./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Oh, you are awake! One of your fellows sent a projectile through your suit, you were losing fluid so I stopped that./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("SOMEONE SHOT ME? WHO WAS IT? Wait I think I know... was it?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("The man wearing the cowboy hat on his space suit?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Fucking thought so. Fucking Jeff. So who are you and where am I?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("I am Thoth goddess of the moon. I have built a palace to keep you safe./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Did you say... Goddess? This is all impossible and crazy is this my final death hallucination?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("This will have to wait. Before you were shot, you told the man in the cowboy hat that if he proceeded with his plans/wait:1//close/ ", "Thoth"));
        dialogTexts.Add(new DialogData("he would destroy the moon?/wait:1//close/ ", "Thoth"));
        dialogTexts.Add(new DialogData("Uhh yea./wait:1//close/ ", "Grace"));
        dialogTexts.Add(new DialogData("And what would that look like?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Like a fleet of gunships coming with mining gear/wait:1//close/ ", "Grace"));
        dialogTexts.Add(new DialogData("Like that fleet of gunships coming at us?/wait:1//close/ ", "Thoth"));
        dialogTexts.Add(new DialogData("Uhh yea that'd be about right./wait:1//close/ ", "Grace"));
        dialogTexts.Add(new DialogData("May I kill them?/wait:1//close/ ", "Thoth"));
        dialogTexts.Add(new DialogData("They are probably mostly drones and Jeff, but you can especially kill Jeff / wait:1//close/ ", "Grace"));
        dialogTexts.Add(new DialogData("I take umbrage at that. I wanted to do this with minimal bloodshed but time to die lil missy./wait:1//close/ ", "Jeff"));
        dialogTexts.Add(new DialogData("No one believes your stupid accent Jeff you are from Seattle./wait:1//close/ ", "Grace"));


        DialogData LastDialogue = new DialogData("/wait:1//close/", "Grace");
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
