class Lasagna
{
    private int MinutesInOven = 40;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => MinutesInOven;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int elapsedTimeInMinutes) => MinutesInOven - elapsedTimeInMinutes;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers * 2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int elapsedTimeInMinutes) => numberOfLayers * 2 + elapsedTimeInMinutes;
}
