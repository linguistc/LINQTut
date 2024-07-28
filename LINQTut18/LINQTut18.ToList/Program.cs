using Shared;
using System;
using System.Collections.Generic;
using System.Linq;


IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

List<Shipping> shippingList = shippings.ToList();

Console.WriteLine($"total shippings: {shippingList.Count}");
Console.WriteLine($"first shipping");
shippingList[0].Start();
shippingList.First().Start();
       