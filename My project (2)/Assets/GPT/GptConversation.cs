using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class GptConversation
{
    [SerializeField] private GptApiSettings apiSettings;
    [SerializeField] private float temperature = 0.7f;
    [SerializeField] private float presencePenalty = 0f;
    [SerializeField] private float frequencyPenalty = 0f;
    [SerializeField] private float topP = 1f;
    [SerializeField] private int maxTokenLength = 600;
    [SerializeField] private bool saveHistory = false;

    protected List<ChatMessage> messagesHistory = new();

}