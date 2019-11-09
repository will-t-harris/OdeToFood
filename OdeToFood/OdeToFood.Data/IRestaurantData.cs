﻿using OdeToFood.Core;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
  public interface IRestaurantData
  {
    IEnumerable<Restaurant> GetAll();
  }

  public class InMemoryRestaurantData : IRestaurantData
  {
    readonly List<Restaurant> restaurants;
    public InMemoryRestaurantData()
    {
      restaurants = new List<Restaurant>()
      {
        new Restaurant {Id = 1, Name = "Will's Pizza", Location = "Maryland", Cuisine = CuisineType.Italian},
        new Restaurant {Id = 2, Name = "Will's Tortilla", Location = "Colorado", Cuisine = CuisineType.Mexican},
        new Restaurant {Id = 3, Name = "Will's Pita", Location = "Florida", Cuisine = CuisineType.Indian},

      };
    }
    public IEnumerable<Restaurant> GetAll()
    {
      return from r in restaurants
             orderby r.Name
             select r;
    }
  }
}
