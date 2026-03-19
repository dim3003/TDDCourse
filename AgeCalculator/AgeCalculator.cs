namespace AgeCalculator;

public class AgeCalculator
{
    public int GetAge(DateTime birthDate, DateTime targetDate)
    {
        var age = targetDate.Year - birthDate.Year;
        if(targetDate.Month < birthDate.Month || (targetDate.Month == birthDate.Month && targetDate.Day < birthDate.Day))
        {
            age--;
        }
        return age;
    }
}
