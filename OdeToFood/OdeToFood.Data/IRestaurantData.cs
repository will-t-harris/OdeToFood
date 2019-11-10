﻿using OdeToFood.Core;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
  public interface IRestaurantData
  {
    IEnumerable<Restaurant> GetRestaurantsByName(string name);
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
    public IEnumerable<Restaurant> GetGetRestaurantsByNameAll(string name = null)
    {
      return from r in restaurants
             where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
             orderby r.Name
             select r;
    }
  }
}
