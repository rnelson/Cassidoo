using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Cassidoo.Safety;

[AttributeUsage(AttributeTargets.Parameter)]
public class IsPositiveIntegerAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        ArgumentNullException.ThrowIfNull(value);

        var valueString = value.ToString();
        if (!int.TryParse(valueString, NumberStyles.Integer, CultureInfo.CurrentCulture, out var integerValue))
            throw new ArgumentException("value must be integer");
        
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(integerValue);

        return true;
    }
}