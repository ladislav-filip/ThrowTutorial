using Throw;

namespace ThrowTutorial;

public static class ValidatableExtensions
{
    public static ref readonly Validatable<DateTime> IfThisCentury(this in Validatable<DateTime> validatable)
    {
        var thisCentury = DateTime.Today.Year / 100;
        var validateCentury = validatable.Value.Year / 100;

        if (thisCentury != validateCentury)
        {
            throw new ArgumentException("Date is not this century", validatable.ParamName);
        }

        return ref validatable;
    }
}