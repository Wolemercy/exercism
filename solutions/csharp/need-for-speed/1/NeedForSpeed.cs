class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    
    private int _distanceDriven = 0;
    private int _batteryLevel = 100;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _batteryLevel < _batteryDrain;

    public int DistanceDriven() => _distanceDriven;

    public void Drive()
    {
        if (this.BatteryDrained())
        {
            return;
        }

        _distanceDriven += _speed;
        _batteryLevel -= _batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _distance;
    
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained()) {
            car.Drive();
            if (car.DistanceDriven() >= _distance)
            {
                return true;
            }
        }

        return false;
    }
}
