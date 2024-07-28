using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

var groundShippings = shippings.Where(x=> x.GetType() == typeof(GroundShipping)).Cast<GroundShipping>();

groundShippings.Process("Ground shippings");

        

public static class SampleExtension
{
    public static IEnumerable<T> Cast<T>(this IEnumerable<T> source)
    {
        foreach (var item in source)
            yield return (T)item;

    }

}

