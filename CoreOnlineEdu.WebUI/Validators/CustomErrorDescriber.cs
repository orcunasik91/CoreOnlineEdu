using Microsoft.AspNetCore.Identity;

namespace CoreOnlineEdu.WebUI.Validators;
public class CustomErrorDescriber : IdentityErrorDescriber
{
    public override IdentityError PasswordRequiresDigit()
    {
        return new IdentityError
        {
            Description = "Şifre En Az Bir Rakam (0,1,2,3,4,5,6,7,8,9) İçermelidir."
        };
    }
    public override IdentityError PasswordRequiresLower()
    {
        return new IdentityError
        {
            Description = "Şifre En Az Bir Küçük Harf (a-z) İçermelidir."
        };
    }
    public override IdentityError PasswordRequiresUpper()
    {
        return new IdentityError
        {
            Description = "Şifre En Az Bir Büyük Harf (A-Z) İçermelidir."
        };
    }
    public override IdentityError PasswordRequiresNonAlphanumeric()
    {
        return new IdentityError
        {
            Description = "Şifre En Az Bir Özel Karakter (.,-_*+) İçermelidir."
        };
    }
    public override IdentityError PasswordTooShort(int length)
    {
        return new IdentityError
        {
            Description = $"Şifre En Az {length} Karakter İçermelidir."
        };
    }
    public override IdentityError DuplicateUserName(string userName)
    {
        return new IdentityError
        {
            Description = $"{userName} Kullanıcı Adıyla Zaten Kayıt Mevcut."
        };
    }
}