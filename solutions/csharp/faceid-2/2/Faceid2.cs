public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    public override bool Equals(object obj) => Object.ReferenceEquals(this, obj) && this.Equals(obj as FacialFeatures);

    public bool Equals(FacialFeatures f)
    {
        return f != null && (EyeColor == f.EyeColor) && (PhiltrumWidth == f.PhiltrumWidth);
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
    public override bool Equals(object obj) => this.Equals(obj as Identity);

    public bool Equals(Identity i)
    {
        return i != null && (Email == i.Email) && (FacialFeatures.Equals(i.FacialFeatures));
    }

    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures);
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

    public bool Register(Identity identity) => _identities.Add(identity);

    public bool IsRegistered(Identity identity) => _identities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return System.Object.ReferenceEquals(identityA, identityB);
    }
}
