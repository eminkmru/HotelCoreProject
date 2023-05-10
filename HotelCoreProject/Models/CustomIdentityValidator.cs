using Microsoft.AspNetCore.Identity;

namespace HotelCoreProject.Models
{
	public class CustomIdentityValidator :IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola Minimum {length} karakter olamalıdır."
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description= "Parola en az bir adet büyük karakter içermelidir."
            };
		}
		public override IdentityError PasswordRequiresLower()
		{
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Parola en az bir adet küçük karakter içermelidir."
            };
        }
		public override IdentityError PasswordRequiresDigit()
		{
            return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Parola en az bir numara içermelidir."
            };
        }
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az bir özel karakter içermelidir."
            };
        }
	}
}
