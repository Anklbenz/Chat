using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChatMessage
{
    public abstract string role { get;  }
    public string message { get; set; }
} 
