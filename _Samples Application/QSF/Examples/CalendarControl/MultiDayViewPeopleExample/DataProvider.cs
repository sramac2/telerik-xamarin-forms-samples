﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace QSF.Examples.CalendarControl.MultiDayViewPeopleExample
{
    public static class DataProvider
    {
        public static IEnumerable<PersonViewModel> GetData(DateTime date)
        {
            var firstColor = Color.FromHex("3148CA");
            var secondColor = Color.FromHex("FF714D");

            return new[]
            {
                new PersonViewModel
                {
                    Name = "Lauren Johnson",
                    Color = firstColor,
                    IsSelected = true,
                    Appointments =
                    {
                        new AppointmentViewModel
                        {
                            StartDate = date.AddHours(8).AddMinutes(30),
                            EndDate = date.AddHours(9).AddMinutes(30),
                            Title = "Fitness with Peter",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddHours(11),
                            EndDate = date.AddHours(12),
                            Title = "Job interview",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddHours(14).AddMinutes(30),
                            EndDate = date.AddHours(15).AddMinutes(30),
                            Title = "Webinar",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddHours(16).AddMinutes(45),
                            EndDate = date.AddHours(17).AddMinutes(45),
                            Title = "Dentist",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddHours(20),
                            EndDate = date.AddHours(22),
                            Title = "Watch a movie",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date,
                            EndDate = date.AddDays(1).AddSeconds(-1),
                            Title = "Alex's birthday",
                            Color = firstColor,
                            IsAllDay = true
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(-1).AddHours(10),
                            EndDate = date.AddDays(-1).AddHours(11).AddMinutes(30),
                            Title = "Innovation Explorer",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(-1).AddHours(13),
                            EndDate = date.AddDays(-1).AddHours(14).AddMinutes(30),
                            Title = "Lunch with the Morgans",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(-1).AddHours(15),
                            EndDate = date.AddDays(-1).AddHours(16),
                            Title = "Conference call with HQ2",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(-2),
                            EndDate = date.AddDays(-1).AddSeconds(-1),
                            Title = "Team building barbecue",
                            Color = firstColor,
                            IsAllDay = true
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(2).AddHours(18),
                            EndDate = date.AddDays(2).AddHours(19),
                            Title = "Favourite show",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(2).AddHours(19),
                            EndDate = date.AddDays(2).AddHours(20).AddMinutes(30),
                            Title = "Planting trees",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(3).AddHours(10),
                            EndDate = date.AddDays(3).AddHours(11),
                            Title = "Coordination meeting",
                            Color = firstColor
                        },
                        new AppointmentViewModel
                        {
                             StartDate = date.AddDays(3).AddHours(18),
                             EndDate = date.AddDays(3).AddHours(19).AddMinutes(30),
                             Title = "Theater evening",
                            Color = firstColor
                         },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(5).AddHours(21),
                            EndDate = date.AddDays(5).AddHours(23),
                            Title = "Birthday party",
                            Color = firstColor
                        }
                    }
                },
                new PersonViewModel
                {
                    Name = "Ollie Wilkinson",
                    Color = secondColor,
                    IsSelected = true,
                    Appointments =
                    {
                        new AppointmentViewModel
                        {
                            StartDate = date.AddHours(10),
                            EndDate = date.AddHours(10).AddMinutes(30),
                            Title = "Daily meeting",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddHours(12).AddMinutes(30),
                            EndDate = date.AddHours(14),
                            Title = "Lunch with Sam",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddHours(16),
                            EndDate = date.AddHours(17).AddMinutes(30),
                            Title = "Tokyo deal call",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddHours(18),
                            EndDate = date.AddHours(19).AddMinutes(30),
                            Title = "Home theater evening",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(-1).AddHours(18),
                            EndDate = date.AddDays(-1).AddHours(19),
                            Title = "Swimming",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(-1).AddHours(20),
                            EndDate = date.AddDays(-1).AddHours(22).AddMinutes(30),
                            Title = "Theater evening",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(-2),
                            EndDate = date.AddDays(-1).AddSeconds(-1),
                            Title = "Mountain biking",
                            Color = secondColor,
                            IsAllDay = true
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(1).AddHours(20),
                            EndDate = date.AddDays(1).AddHours(22),
                            Title = "Date with Candice",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(2).AddHours(16).AddMinutes(30),
                            EndDate = date.AddDays(2).AddHours(17),
                            Title = "Daily meeting",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(2).AddHours(19),
                            EndDate = date.AddDays(2).AddHours(20).AddMinutes(30),
                            Title = "Football",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(2),
                            EndDate = date.AddDays(4).AddSeconds(-1),
                            Title = "Movies Festival",
                            Color = secondColor,
                            IsAllDay = true
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(2),
                            EndDate = date.AddDays(11).AddSeconds(-1),
                            Title = "Vacation",
                            Color = secondColor,
                            IsAllDay = true
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(3).AddHours(15),
                            EndDate = date.AddDays(3).AddHours(16).AddMinutes(30),
                            Title = "Table tennis",
                            Color = secondColor
                        },
                        new AppointmentViewModel
                        {
                            StartDate = date.AddDays(4).AddHours(9),
                            EndDate =  date.AddDays(4).AddHours(10),
                            Title = "Conference call with Tokyo",
                            Color = secondColor
                        }
                    }
                }
            };
        }
    }
}
