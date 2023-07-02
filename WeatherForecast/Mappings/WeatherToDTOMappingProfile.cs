﻿using AutoMapper;
using WeatherForecast.DTOs;
using WeatherForecast.Models;

namespace WeatherForecast.Mappings;

public class WeatherToDTOMappingProfile : Profile
{
    public WeatherToDTOMappingProfile()
    {
        CreateMap<Weather, WeatherDTO>()
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Location.Name))
            .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Location.Region))
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Location.Country))
            .ForMember(dest => dest.Localtime, opt => opt.MapFrom(src => src.Location.Localtime))
            .ForMember(dest => dest.LastUpdate, opt => opt.MapFrom(src => src.Current.LastUpdated))
            .ForMember(dest => dest.CelsiusTemperature, opt => opt.MapFrom(src => src.Current.TempC))
            .ForMember(dest => dest.FahrenheitTemperature, opt => opt.MapFrom(src => src.Current.TempF))
            .ForMember(dest => dest.Condition, opt => opt.MapFrom(src => src.Current.Condition.Text))
            .ForMember(dest => dest.Humidity, opt => opt.MapFrom(src => src.Current.Humidity))
            .ForMember(dest => dest.ForecastList, opt => opt.MapFrom(src => src.Forecast.Forecastday.Select(f => new ForecastDaySummary(f.Date, f.Day!.MaxtempC, f.Day.MintempC, f.Day.MaxtempF, f.Day.MintempF, f.Day.TotalprecipMm, f.Day.Condition.Text, f.Day.Condition.Icon)
            )));
    }
}

