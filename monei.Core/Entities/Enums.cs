namespace monei.Core.Entities
{
    public enum AccountRole
    {
        Administrator,
        User,
    }

    public enum EntryType
    {
        Outcome = -1,
        Transfer = 0,
        Income = +1        
    }
}
