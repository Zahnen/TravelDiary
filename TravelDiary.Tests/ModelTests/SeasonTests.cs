using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravelDiary.Models;
using System.Collections.Generic;
using System;

namespace TravelDiary.Tests
{
  [TestClass]
  public class SeasonTest
  {
    [TestMethod]
    public void SeasonConstructor_CreatesAnInstanceOfSeason_Season()
    {
      Season newSeason = new Season("test string");
      Assert.AreEqual(typeof(Season), newSeason.GetType());
    }
  }
}

