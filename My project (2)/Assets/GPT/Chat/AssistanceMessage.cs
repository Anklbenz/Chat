using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssistanceMessage : ChatMessage
{
    private const string ROLE = "assistance";
    public override string role => ROLE;
}
