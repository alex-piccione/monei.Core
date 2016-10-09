namespace monei.Core.Entities
{
    public enum AccountRole
    {
        Administrator,
        User,
    }

    public enum FactType {
        Transfer = 0,
        Income = +1,
        Outcome = -1
    }
}
