static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        var today = DateTime.Now;
        return appointmentDate < today;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        var hour = appointmentDate.Hour;
        return hour >= 12 && hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString()}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(2026, 9, 15);
    }
}
