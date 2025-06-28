using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Validations
{
    public class ListLengthAttribute : ValidationAttribute
    {
        private readonly int minLength;
        public ListLengthAttribute(int length = 1)
        {
            minLength = length;
        }
        public override bool IsValid(object? value)
        {
            if (value is not System.Collections.IList list)
            {
                return true; 
            }
            return list.Count >= minLength; 
        }

        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(name + " Must be its length greater than "+ minLength);
        }

    }
}
