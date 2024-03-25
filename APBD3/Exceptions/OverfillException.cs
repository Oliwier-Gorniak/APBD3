namespace APBD3.Exceptions;

public class OverfillException : Exception
{
    public OverfillException() : base("The container is overfilled.")
    {
    }
}