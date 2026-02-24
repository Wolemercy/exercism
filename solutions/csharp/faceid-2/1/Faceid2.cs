public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj) => this.Equals(obj as FacialFeatures);

    public bool Equals(FacialFeatures f)
    {
         if (f is null)
         {
             return false;
         }

        if (Object.ReferenceEquals(this, f)){
            return true;
        }

        if (this.GetType() != f.GetType()){
            return false;
        }

        return (EyeColor == f.EyeColor) && (PhiltrumWidth == f.PhiltrumWidth);
    }

    public override int GetHashCode() => (EyeColor, PhiltrumWidth).GetHashCode();
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj) => this.Equals(obj as Identity);

    public bool Equals(Identity i)
    {
         if (i is null)
         {
             return false;
         }

        if (Object.ReferenceEquals(this, i)){
            return true;
        }

        if (this.GetType() != i.GetType()){
            return false;
        }

        return (Email == i.Email) && (FacialFeatures.Equals(i.FacialFeatures));
    }

    public override int GetHashCode() => (Email, FacialFeatures).GetHashCode();
}

public class Authenticator
{
    private HashSet<Identity> _identities = new();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        var adminEmail = "admin@exerc.ism";
        var adminFacialFeatures = new FacialFeatures("green", 0.9m);
        return identity.Equals(new Identity(adminEmail, adminFacialFeatures));
    }

    public bool Register(Identity identity)
    {
        if (_identities.Contains(identity)){
            return false;
        }

        _identities.Add(identity);
        return true;
    }

    public bool IsRegistered(Identity identity)
    {
        return _identities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return System.Object.ReferenceEquals(identityA, identityB);
    }
}
