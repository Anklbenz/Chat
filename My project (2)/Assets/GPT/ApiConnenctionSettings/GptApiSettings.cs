using UnityEngine;

[CreateAssetMenu(fileName = "GptApiSettings", menuName = "ScriptableObjects/GptApiSettings", order = 1)]
public class GptApiSettings : ScriptableObject
{
    private const string DEFAULT_OPEN_AI_URL = @"https://api.openai.com/v1/chat/completions";
 //   public ChatModels Model = ChatModels.GPT_3_5_TURBO; 
    public string url = DEFAULT_OPEN_AI_URL;
    public string apiKey;
    public string organization;
}