using System;
using Shared;
using System.Linq;

ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;
            
var todayShipping = shippings.Where(x=>x.ShippingDate == DateTime.Today);

todayShipping.Process("Today's shipping using ShippingList<T> Where");
             
           
var todayShipping2 = shippings.AsEnumerable().Where(x => x.ShippingDate == DateTime.Today);

todayShipping2.Process("Today's shipping using IEnumerable<T> Where");

            
