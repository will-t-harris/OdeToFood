﻿using OdeToFood.Core;
using System;
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
    List<Restaurant> restaurants;
    public InMemoryRestaurantData()
    {
      restaurants = new List<Restaurant>()
      {
        new Restaurant {Id = 1, Name = "Will's Pizza", Location = "New Mexico", Cuisine = CuisineType.Italian},
        new Restaurant {Id = 2, Name = "Cinnamon Club", Location = "London", Cuisine = CuisineType.Indian},
        new Restaurant {Id = 3, Name = "La Costa", Location = "California", Cuisine = CuisineType.Mexican}
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
