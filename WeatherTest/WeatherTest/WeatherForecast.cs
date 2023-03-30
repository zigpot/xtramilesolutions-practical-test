namespace WeatherTest;

public class WeatherForecast
{
		public string Location { get; set; }

		public string Wind { get; set; }

		public string Visibility { get; set; }

		public string SkyCondition { get; set; }

		public float DewPoint { get; set; }

		public float RelativeHumidity { get; set; }

		public float Pressure { get; set; }

    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
