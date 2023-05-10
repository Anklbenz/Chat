using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserMessage : ChatMessage
{
    private const string ROLE = "user";
    public override string role => ROLE;
}
