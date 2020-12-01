using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Doublsb.Dialog;

public class L4Dialogu : MonoBehaviour
{
    public DialogManager DialogManager;
    public GameObject DialogAsset;

    // Start is called before the first frame update
    void Start()
    {

        var dialogTexts = new List<DialogData>();
        dialogTexts.Add(new DialogData("So what's it like being moon goddess?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("It is fine as far as I know, I do not have many points of comparison./wait:1//close/ ", "Thoth"));
        


        dialogTexts.Add(new DialogData("In the old days people would worship me more and now a little less, it is just different./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("The last few weeks with you have been nice though. What about you how did you come here?/wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Well... that's a long story the short of it is, the corps dumped space research when it wasn't immediately paying off./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("So over time a sort of SpacePunk scene developed, using AI, additive manufacturing, and biofuels we managed to get rocks off the ground cheap./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("And before you know it me and a fake cowboy were fighting over dating a Russian, we were putting our own satellites up and my half sibling had done a space walk./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("But the moon was a bigger jump so I put together some BS about moon fuel and precious gems, it was plausible enough to get national funding but I thought it was BS./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Well Sochi looked into the numbers, she'd always been, tied to corps more, and before you know it we have funding out the ears./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("I could see Jeff seeing the dollar signs in his eyes, and Sochi craved power more than anything./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("I don't blame the corps, they're just lawnmowers. And I like to believe if Sochi and Jeff..../wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("were willing to look past their desires they'd realize that this would destroy the moon and eventually ruin the tides on earth./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("But Money is a big statistical weight against data.... *sigh* and now I'm fighting my friends to stop them from killing their grandkids./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Why can't it go back to like it was/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("If I may offer some advice, forgiveness is hard when this is all over you might find a way to./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("HELLO DIRTBAGS. The gang's all here./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("And we're ready to have us an OK corral./wait:1//close/ ", "Jeff"));


        dialogTexts.Add(new DialogData("I'm not with them, I just want to help you get free from this moon witch./wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("What you aren't going to come in steadily increasing waves where you ally as pairs and then slowly prep for a huge attack?/wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("Uhh learn some tactics Grace, that would be tactically awful, massed forces are how you win war and I've massed a lot of forces./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("That saves me time./wait:1//close/ ", "Thoth"));


        dialogTexts.Add(new DialogData("Guys. This hurts me but I've gotta do this./wait:1//close/ ", "Grace"));


        dialogTexts.Add(new DialogData("It's sad we must let bullets decide what is a scientific issue./wait:1//close/ ", "Natalia"));


        dialogTexts.Add(new DialogData("Power is Power whether it's guns or money or studies and power decides what is right everything else is some wuss trying to convince you to give them power./wait:1//close/ ", "Sochi"));


        dialogTexts.Add(new DialogData("Game on fuckers./wait:1//close/ ", "Sochi"));


        DialogData LastDialogue = new DialogData("/close/", "Sochi");
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
