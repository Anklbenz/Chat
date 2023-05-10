public class SystemMessage: ChatMessage
{
    private const string ROLE = "system";
    public override string role => ROLE;
}
