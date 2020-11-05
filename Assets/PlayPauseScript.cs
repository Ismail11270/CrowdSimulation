using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class PlayPauseScript : MonoBehaviour
{
    public Button playPauseButton;
    
    private Text buttonText;

    private bool running;

    public GameObject agentsParent;

    private NavMeshAgent[] agents;
    private Animator[] animators;
    
    // Start is called before the first frame update
    void Start()
    {
        buttonText = GetComponentInChildren<Text>();
        running = true;
        agents = agentsParent.GetComponentsInChildren<NavMeshAgent>();
        animators = agentsParent.GetComponentsInChildren<Animator>();
        
        Debug.Log(" SIZE " + animators.Length + " Patrols");
        Debug.Log(" SIZE " + agents.Length+ " Animators");
        TriggerSimulation(!running);

        playPauseButton.onClick.AddListener(delegate { OnClick(); });

        Debug.Log(agents[0].areaMask + " area mask");
    }


    public void OnClick()
    {
        Debug.Log("Clicked");
        TriggerSimulation(!running);
    }

    public void TriggerSimulation(bool on)
    {
        int areaMask = on ? 1 : 0;
        foreach (NavMeshAgent agent in agents)
        {
            agent.areaMask = areaMask;
        }
        foreach (Animator animator in animators)
        {
            animator.enabled = on;
        }
        running = on;
        if (running) buttonText.text = "STOP";
        else buttonText.text = "START";

        Debug.Log("Triggered");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
