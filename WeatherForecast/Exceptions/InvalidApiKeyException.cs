namespace WeatherForecast.Exceptions;

public class InvalidApiKeyException: Exception
{
    public InvalidApiKeyException(string message): base(message)
    {        
    }
}
