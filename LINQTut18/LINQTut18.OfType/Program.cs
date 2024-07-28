using Shared;
using System;
using System.Collections.Generic;
using System.Linq;

IEnumerable<Shipping> shippings = ShippingRepository.AllAsList;

var groundShippings = shippings.OfType<GroundShipping>();

groundShippings.Process("Ground shippings");

           
public static class SampleExtension
{
    public static IEnumerable<T> Cast<T>(this IEnumerable<T> source)
    {
        foreach (var item in source)
        { 
            if(item is T)
                yield return (T)item;
        }

    }

}

