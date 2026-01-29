class BirdCount
{
    private int[] birdsPerDay;
    private int numberOfDays;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
        this.numberOfDays = birdsPerDay.Length;
    }

    public static int[] LastWeek() => new[] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today() => birdsPerDay[this.numberOfDays - 1];

    public void IncrementTodaysCount()
    {
        var todaysCount = birdsPerDay[this.numberOfDays - 1];
        birdsPerDay[this.numberOfDays - 1] = todaysCount + 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birdCount in birdsPerDay)
        {
            if (birdCount == 0)
            {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int totalCount = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            totalCount += birdsPerDay[i];
        }

        return totalCount;
    }

    public int BusyDays()
    {
        int numberOfBusyDays = 0;

        foreach (int birdCount in birdsPerDay)
        {
            if (birdCount >= 5)
            {
                numberOfBusyDays += 1;
            }
        }

        return numberOfBusyDays;
    }
}
