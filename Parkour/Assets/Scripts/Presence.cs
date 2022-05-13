using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord; 

public class Presence : MonoBehaviour
{
    long clientId = 968722376458117120; 
    Discord.Discord discord; 
    // Start is called before the first frame update
    void Start()
    {
        discord = new Discord.Discord(clientId, (System.UInt64)CreateFlags.NoRequireDiscord);
        var activityManager = discord.GetActivityManager();
        var activity = new Activity
        {
            State = "Probably grinding till the end.",
            Assets = { LargeImage = "parkour" },
            Timestamps = { Start = System.DateTimeOffset.Now.ToUnixTimeSeconds() }
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res == Result.Ok)
            {
                Debug.LogError("Cope and Seethe");
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        discord.RunCallbacks(); 
    }
}
